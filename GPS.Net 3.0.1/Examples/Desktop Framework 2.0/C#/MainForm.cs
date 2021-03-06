﻿using System;
using System.IO;
using System.Windows.Forms;
using GeoFramework;
using GeoFramework.Gps;
using GeoFramework.Gps.Emulators;
using GeoFramework.Gps.Nmea;
using GeoFramework.Gps.IO;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        /* In case no GPS device can be found, we can use a GPS device emulator.
         * The VirtualDevice class encapsulates all GPS simulation features.
         */
        private VirtualDevice emulator = VirtualDevice.Default;

        public MainForm()
        {
            InitializeComponent();

            /* Hook into GPS.NET's device detection events.  These events will report on
             * any GPS devices which have been found, along with any problems encountered and reasons
             * why a particular device could NOT be detected.
             */
            Devices.DeviceDetectionAttempted += new EventHandler<DeviceEventArgs>(Devices_DeviceDetectionAttempted);
            Devices.DeviceDetectionAttemptFailed += new EventHandler<DeviceDetectionExceptionEventArgs>(Devices_DeviceDetectionAttemptFailed);
            Devices.DeviceDetectionStarted += new EventHandler(Devices_DeviceDetectionStarted);
            Devices.DeviceDetectionCompleted += new EventHandler(Devices_DeviceDetectionCompleted);
            Devices.DeviceDetectionCanceled += new EventHandler(Devices_DeviceDetectionCanceled);
            Devices.DeviceDetected += new EventHandler<DeviceEventArgs>(Devices_DeviceDetected);

            /* GPS.NET 3.0 includes several Windows Forms controls for displaying real-time GPS data.
             * For them to work properly, they must be bound to an interpreter object.
             */
            altimeter1.SetInterpreter(nmeaInterpreter1);
            compass1.SetInterpreter(nmeaInterpreter1);
            satelliteViewer1.SetInterpreter(nmeaInterpreter1);
            speedometer1.SetInterpreter(nmeaInterpreter1);
        }

        #region GPS Device Detection Events

        void Devices_DeviceDetectionCanceled(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Device detection canceled!";
                detectButton.Enabled = true;
                cancelDetectButton.Enabled = false;
            }));
        }

        void Devices_DeviceDetected(object sender, DeviceEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                foreach (ListViewItem item in devicesListView.Items)
                {
                    if (object.ReferenceEquals(item.Tag, e.Device))
                    {
                        item.SubItems[1].Text = "GPS DETECTED";
                        item.ImageIndex = 0;
                    }
                }
                devicesListView.Refresh();
            }));
        }

        void Devices_DeviceDetectionCompleted(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Device detection complete.";
                detectButton.Enabled = true;
                cancelDetectButton.Enabled = false;
            }));
        }

        void Devices_DeviceDetectionStarted(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Detecting GPS devices...";
                devicesListView.Items.Clear();
                detectButton.Enabled = false;
                cancelDetectButton.Enabled = true;
            }));
        }

        void Devices_DeviceDetectionAttemptFailed(object sender, DeviceDetectionExceptionEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                foreach (ListViewItem item in devicesListView.Items)
                {
                    if (object.ReferenceEquals(item.Tag, e.Device))
                    {
                        item.SubItems[1].Text = e.Exception.Message;
                        item.ToolTipText = e.Exception.Message;
                        item.ImageIndex = 1;
                    }
                }
                devicesListView.Refresh();
            }));
        }

        void Devices_DeviceDetectionAttempted(object sender, DeviceEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                ListViewItem item = new ListViewItem();
                item.Text = e.Device.Name;
                item.ImageIndex = 2;
                item.Tag = e.Device;
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, "Detecting..."));
                devicesListView.Items.Add(item);
                devicesListView.Refresh();
            }));
        }

        #endregion

        #region NmeaInterpreter Events

        private void nmeaInterpreter1_SpeedChanged(object sender, SpeedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                speedTextBox.Text = e.Speed.ToString();
            }));

        }

        private void nmeaInterpreter1_BearingChanged(object sender, AzimuthEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                bearingTextBox.Text = e.Azimuth.ToString();
            }));
        }

        private void nmeaInterpreter1_AltitudeChanged(object sender, DistanceEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                altitudeTextBox.Text = e.Distance.ToString();
            }));

        }


        private void nmeaInterpreter1_Paused(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                pauseButton.Enabled = false;
                resumeButton.Enabled = true;
            }));
        }

        private void nmeaInterpreter1_Resumed(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                pauseButton.Enabled = true;
                resumeButton.Enabled = false;
            }));
        }

        private void nmeaInterpreter1_Starting(object sender, DeviceEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Connecting to " + e.Device.Name + "...";
            }));
        }

        private void nmeaInterpreter1_Started(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Connected!  Waiting for data...";
                sentenceListBox.Items.Clear();
                startButton.Enabled = false;
                stopButton.Enabled = true;
                pauseButton.Enabled = true;
                resumeButton.Enabled = false;
            }));
        }

        private void nmeaInterpreter1_Stopping(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Stopping GPS device...";
            }));
        }

        private void nmeaInterpreter1_Stopped(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                statusLabel.Text = "Stopped.";
                startButton.Enabled = true;
                stopButton.Enabled = false;
                pauseButton.Enabled = false;
                resumeButton.Enabled = false;
            }));
        }


        private void nmeaInterpreter1_SatellitesChanged(object sender, SatelliteListEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                foreach (Satellite satellite in e.Satellites)
                {
                    // Look for an existing satellite
                    foreach (ListViewItem viewItem in satellitesListView.Items)
                    {
                        Satellite existing = (Satellite)viewItem.Tag;
                        if (existing.PseudorandomNumber.Equals(satellite.PseudorandomNumber))
                        {
                            // Update shiz
                            viewItem.SubItems[2].Text = satellite.Azimuth.ToString();
                            viewItem.SubItems[3].Text = satellite.Elevation.ToString();
                            viewItem.SubItems[4].Text = satellite.SignalToNoiseRatio.ToString();
                            return;
                        }
                    }

                    ListViewItem newItem = new ListViewItem(satellite.PseudorandomNumber.ToString());
                    newItem.SubItems.Add(satellite.Name);
                    newItem.SubItems.Add(satellite.Azimuth.ToString());
                    newItem.SubItems.Add(satellite.Elevation.ToString());
                    newItem.SubItems.Add(satellite.SignalToNoiseRatio.ToString());
                    newItem.Tag = satellite;
                    satellitesListView.Items.Add(newItem);
                }
            }));
        }

        private void nmeaInterpreter1_PositionChanged(object sender, PositionEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                positionTextBox.Text = e.Position.ToString();
            }));
        }

        private void nmeaInterpreter1_DateTimeChanged(object sender, DateTimeEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                dateTimeTextBox.Text = e.DateTime.ToShortDateString() + " " + e.DateTime.ToLongTimeString();
                utcDateTimeTextBox.Text = e.DateTime.ToUniversalTime().ToString("R");
            }));
        }

        private void nmeaInterpreter1_SentenceReceived(object sender, GeoFramework.Gps.Nmea.NmeaSentenceEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                if (sentenceListBox.Items.Count >= 100)
                    sentenceListBox.Items.RemoveAt(0);

                sentenceListBox.Items.Add(e.Sentence.ToString());
                sentenceListBox.SelectedIndex = sentenceListBox.Items.Count - 1;
            }));
        }

        #endregion

        #region Button Events

        private void detectButton_Click(object sender, EventArgs e)
        {
            Devices.BeginDetection();
        }

        private void cancelDetectButton_Click(object sender, EventArgs e)
        {
            Devices.CancelDetection();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                nmeaInterpreter1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot connect to GPS");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            nmeaInterpreter1.Stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            nmeaInterpreter1.Pause();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            nmeaInterpreter1.Resume();
        }

        #endregion

        #region Other Form Control Events

        private void devicesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            propertyGrid1.SelectedObject = e.Item.Tag;
        }

        private void serialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Devices.AllowSerialConnections = serialCheckBox.Checked;
        }

        private void bluetoothCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Devices.AllowBluetoothConnections = bluetoothCheckBox.Checked;
        }


        private void simulateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulateCheckBox.Checked)
            {
                if (!Devices.GpsDevices.Contains(emulator))
                    Devices.GpsDevices.Add(emulator);
            }
            else
            {
                if (Devices.GpsDevices.Contains(emulator))
                    Devices.GpsDevices.Remove(emulator);
            }
        }

        #endregion
    }

}
