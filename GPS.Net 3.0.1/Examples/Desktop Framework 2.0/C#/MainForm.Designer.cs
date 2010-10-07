﻿namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            nmeaInterpreter1.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.sentenceListBox = new System.Windows.Forms.ListBox();
            this.altitudeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.utcDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detectButton = new System.Windows.Forms.Button();
            this.cancelDetectButton = new System.Windows.Forms.Button();
            this.devicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.devicesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.speedometer1 = new GeoFramework.Gps.Controls.Speedometer();
            this.satelliteViewer1 = new GeoFramework.Gps.Controls.SatelliteViewer();
            this.compass1 = new GeoFramework.Gps.Controls.Compass();
            this.altimeter1 = new GeoFramework.Gps.Controls.Altimeter();
            this.bearingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rawDataTab = new System.Windows.Forms.TabPage();
            this.satellitesTab = new System.Windows.Forms.TabPage();
            this.satellitesListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.nmeaInterpreter1 = new GeoFramework.Gps.Nmea.NmeaInterpreter();
            this.serialCheckBox = new System.Windows.Forms.CheckBox();
            this.bluetoothCheckBox = new System.Windows.Forms.CheckBox();
            this.simulateCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.devicesTab.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.rawDataTab.SuspendLayout();
            this.satellitesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(578, 85);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(578, 114);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(98, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(578, 156);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(98, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resumeButton.Enabled = false;
            this.resumeButton.Location = new System.Drawing.Point(578, 186);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(98, 23);
            this.resumeButton.TabIndex = 3;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // sentenceListBox
            // 
            this.sentenceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentenceListBox.FormattingEnabled = true;
            this.sentenceListBox.Location = new System.Drawing.Point(0, 0);
            this.sentenceListBox.Name = "sentenceListBox";
            this.sentenceListBox.Size = new System.Drawing.Size(552, 446);
            this.sentenceListBox.TabIndex = 4;
            // 
            // altitudeTextBox
            // 
            this.altitudeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.altitudeTextBox.Location = new System.Drawing.Point(131, 102);
            this.altitudeTextBox.Name = "altitudeTextBox";
            this.altitudeTextBox.Size = new System.Drawing.Size(407, 22);
            this.altitudeTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Altitude:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.speedTextBox.Location = new System.Drawing.Point(131, 128);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(407, 22);
            this.speedTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Speed:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.positionTextBox.Location = new System.Drawing.Point(131, 73);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(407, 22);
            this.positionTextBox.TabIndex = 5;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(20, 76);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(52, 13);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "Position:";
            // 
            // utcDateTimeTextBox
            // 
            this.utcDateTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.utcDateTimeTextBox.Location = new System.Drawing.Point(131, 44);
            this.utcDateTimeTextBox.Name = "utcDateTimeTextBox";
            this.utcDateTimeTextBox.Size = new System.Drawing.Size(407, 22);
            this.utcDateTimeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UTC Date/Time:";
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTextBox.Location = new System.Drawing.Point(131, 16);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.Size = new System.Drawing.Size(407, 22);
            this.dateTimeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date/Time:";
            // 
            // detectButton
            // 
            this.detectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detectButton.Location = new System.Drawing.Point(578, 13);
            this.detectButton.Name = "detectButton";
            this.detectButton.Size = new System.Drawing.Size(98, 23);
            this.detectButton.TabIndex = 6;
            this.detectButton.Text = "Detect";
            this.detectButton.UseVisualStyleBackColor = true;
            this.detectButton.Click += new System.EventHandler(this.detectButton_Click);
            // 
            // cancelDetectButton
            // 
            this.cancelDetectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelDetectButton.Enabled = false;
            this.cancelDetectButton.Location = new System.Drawing.Point(578, 42);
            this.cancelDetectButton.Name = "cancelDetectButton";
            this.cancelDetectButton.Size = new System.Drawing.Size(98, 23);
            this.cancelDetectButton.TabIndex = 7;
            this.cancelDetectButton.Text = "Cancel";
            this.cancelDetectButton.UseVisualStyleBackColor = true;
            this.cancelDetectButton.Click += new System.EventHandler(this.cancelDetectButton_Click);
            // 
            // devicesListView
            // 
            this.devicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.devicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesListView.LargeImageList = this.imageList1;
            this.devicesListView.Location = new System.Drawing.Point(0, 0);
            this.devicesListView.Name = "devicesListView";
            this.devicesListView.Size = new System.Drawing.Size(309, 448);
            this.devicesListView.SmallImageList = this.imageList1;
            this.devicesListView.TabIndex = 8;
            this.devicesListView.UseCompatibleStateImageBehavior = false;
            this.devicesListView.View = System.Windows.Forms.View.Details;
            this.devicesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.devicesListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device Name";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 641;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gps.png");
            this.imageList1.Images.SetKeyName(1, "GpsRemove.png");
            this.imageList1.Images.SetKeyName(2, "Configuration Tools.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 17);
            this.statusLabel.Text = "Idle.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.devicesTab);
            this.tabControl1.Controls.Add(this.dataTab);
            this.tabControl1.Controls.Add(this.rawDataTab);
            this.tabControl1.Controls.Add(this.satellitesTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 480);
            this.tabControl1.TabIndex = 11;
            // 
            // devicesTab
            // 
            this.devicesTab.Controls.Add(this.splitContainer1);
            this.devicesTab.Location = new System.Drawing.Point(4, 22);
            this.devicesTab.Name = "devicesTab";
            this.devicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.devicesTab.Size = new System.Drawing.Size(552, 454);
            this.devicesTab.TabIndex = 0;
            this.devicesTab.Text = "Devices";
            this.devicesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.devicesListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(546, 448);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 10;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(233, 448);
            this.propertyGrid1.TabIndex = 9;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.speedometer1);
            this.dataTab.Controls.Add(this.satelliteViewer1);
            this.dataTab.Controls.Add(this.compass1);
            this.dataTab.Controls.Add(this.altimeter1);
            this.dataTab.Controls.Add(this.bearingTextBox);
            this.dataTab.Controls.Add(this.label5);
            this.dataTab.Controls.Add(this.altitudeTextBox);
            this.dataTab.Controls.Add(this.speedTextBox);
            this.dataTab.Controls.Add(this.label3);
            this.dataTab.Controls.Add(this.label1);
            this.dataTab.Controls.Add(this.dateTimeTextBox);
            this.dataTab.Controls.Add(this.label4);
            this.dataTab.Controls.Add(this.label2);
            this.dataTab.Controls.Add(this.positionTextBox);
            this.dataTab.Controls.Add(this.utcDateTimeTextBox);
            this.dataTab.Controls.Add(this.positionLabel);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(552, 454);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "Real-Time Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // speedometer1
            // 
            this.speedometer1.AnalogFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.speedometer1.BackColor = System.Drawing.Color.Black;
            this.speedometer1.DigitalFont = new System.Drawing.Font("Arial", 8F);
            this.speedometer1.IsCheckingTickIntersections = false;
            this.speedometer1.Location = new System.Drawing.Point(410, 189);
            this.speedometer1.Name = "speedometer1";
            this.speedometer1.Size = new System.Drawing.Size(128, 128);
            this.speedometer1.TabIndex = 18;
            this.speedometer1.Text = "speedometer1";
            // 
            // satelliteViewer1
            // 
            this.satelliteViewer1.Bearing = new GeoFramework.Azimuth(0);
            this.satelliteViewer1.CardinalFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.satelliteViewer1.Location = new System.Drawing.Point(6, 186);
            this.satelliteViewer1.Name = "satelliteViewer1";
            this.satelliteViewer1.Size = new System.Drawing.Size(128, 128);
            this.satelliteViewer1.TabIndex = 17;
            this.satelliteViewer1.Text = "satelliteViewer1";
            // 
            // compass1
            // 
            this.compass1.Bearing = new GeoFramework.Azimuth(0);
            this.compass1.CardinalFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.compass1.DegreeFont = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.compass1.Location = new System.Drawing.Point(140, 186);
            this.compass1.Name = "compass1";
            this.compass1.Size = new System.Drawing.Size(128, 128);
            this.compass1.TabIndex = 16;
            this.compass1.Text = "compass1";
            // 
            // altimeter1
            // 
            this.altimeter1.AnalogFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.altimeter1.BackColor = System.Drawing.Color.Black;
            this.altimeter1.DigitalFont = new System.Drawing.Font("Arial", 8F);
            this.altimeter1.DigitalReadoutOrientation = GeoFramework.Gps.Controls.AltimeterDigitalReadoutOrientation.Above;
            this.altimeter1.IsCheckingTickIntersections = false;
            this.altimeter1.Location = new System.Drawing.Point(274, 186);
            this.altimeter1.Name = "altimeter1";
            this.altimeter1.Size = new System.Drawing.Size(128, 128);
            this.altimeter1.TabIndex = 14;
            this.altimeter1.Text = "altimeter1";
            // 
            // bearingTextBox
            // 
            this.bearingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bearingTextBox.Location = new System.Drawing.Point(131, 156);
            this.bearingTextBox.Name = "bearingTextBox";
            this.bearingTextBox.Size = new System.Drawing.Size(407, 22);
            this.bearingTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bearing:";
            // 
            // rawDataTab
            // 
            this.rawDataTab.Controls.Add(this.sentenceListBox);
            this.rawDataTab.Location = new System.Drawing.Point(4, 22);
            this.rawDataTab.Name = "rawDataTab";
            this.rawDataTab.Size = new System.Drawing.Size(552, 454);
            this.rawDataTab.TabIndex = 2;
            this.rawDataTab.Text = "Raw Data";
            this.rawDataTab.UseVisualStyleBackColor = true;
            // 
            // satellitesTab
            // 
            this.satellitesTab.Controls.Add(this.satellitesListView);
            this.satellitesTab.Location = new System.Drawing.Point(4, 22);
            this.satellitesTab.Name = "satellitesTab";
            this.satellitesTab.Size = new System.Drawing.Size(552, 454);
            this.satellitesTab.TabIndex = 3;
            this.satellitesTab.Text = "Satelllites";
            this.satellitesTab.UseVisualStyleBackColor = true;
            // 
            // satellitesListView
            // 
            this.satellitesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.satellitesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satellitesListView.Location = new System.Drawing.Point(0, 0);
            this.satellitesListView.Name = "satellitesListView";
            this.satellitesListView.Size = new System.Drawing.Size(552, 454);
            this.satellitesListView.TabIndex = 0;
            this.satellitesListView.UseCompatibleStateImageBehavior = false;
            this.satellitesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Satellite ID";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 257;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Azimuth";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Elevation";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Signal Strength";
            this.columnHeader7.Width = 95;
            // 
            // nmeaInterpreter1
            // 
            this.nmeaInterpreter1.IsFilterEnabled = false;
            this.nmeaInterpreter1.ThreadPriority = System.Threading.ThreadPriority.BelowNormal;
            this.nmeaInterpreter1.Started += new System.EventHandler(this.nmeaInterpreter1_Started);
            this.nmeaInterpreter1.SpeedChanged += new System.EventHandler<GeoFramework.SpeedEventArgs>(this.nmeaInterpreter1_SpeedChanged);
            this.nmeaInterpreter1.Stopping += new System.EventHandler(this.nmeaInterpreter1_Stopping);
            this.nmeaInterpreter1.BearingChanged += new System.EventHandler<GeoFramework.AzimuthEventArgs>(this.nmeaInterpreter1_BearingChanged);
            this.nmeaInterpreter1.AltitudeChanged += new System.EventHandler<GeoFramework.DistanceEventArgs>(this.nmeaInterpreter1_AltitudeChanged);
            this.nmeaInterpreter1.DateTimeChanged += new System.EventHandler<GeoFramework.DateTimeEventArgs>(this.nmeaInterpreter1_DateTimeChanged);
            this.nmeaInterpreter1.Paused += new System.EventHandler(this.nmeaInterpreter1_Paused);
            this.nmeaInterpreter1.PositionChanged += new System.EventHandler<GeoFramework.PositionEventArgs>(this.nmeaInterpreter1_PositionChanged);
            this.nmeaInterpreter1.SentenceReceived += new System.EventHandler<GeoFramework.Gps.Nmea.NmeaSentenceEventArgs>(this.nmeaInterpreter1_SentenceReceived);
            this.nmeaInterpreter1.Stopped += new System.EventHandler(this.nmeaInterpreter1_Stopped);
            this.nmeaInterpreter1.SatellitesChanged += new System.EventHandler<GeoFramework.Gps.SatelliteListEventArgs>(this.nmeaInterpreter1_SatellitesChanged);
            this.nmeaInterpreter1.Starting += new System.EventHandler<GeoFramework.Gps.IO.DeviceEventArgs>(this.nmeaInterpreter1_Starting);
            this.nmeaInterpreter1.Resumed += new System.EventHandler(this.nmeaInterpreter1_Resumed);
            // 
            // serialCheckBox
            // 
            this.serialCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialCheckBox.AutoSize = true;
            this.serialCheckBox.Checked = true;
            this.serialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serialCheckBox.Location = new System.Drawing.Point(578, 234);
            this.serialCheckBox.Name = "serialCheckBox";
            this.serialCheckBox.Size = new System.Drawing.Size(86, 17);
            this.serialCheckBox.TabIndex = 12;
            this.serialCheckBox.Text = "Allow Serial";
            this.serialCheckBox.UseVisualStyleBackColor = true;
            this.serialCheckBox.CheckedChanged += new System.EventHandler(this.serialCheckBox_CheckedChanged);
            // 
            // bluetoothCheckBox
            // 
            this.bluetoothCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bluetoothCheckBox.AutoSize = true;
            this.bluetoothCheckBox.Checked = true;
            this.bluetoothCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bluetoothCheckBox.Location = new System.Drawing.Point(578, 257);
            this.bluetoothCheckBox.Name = "bluetoothCheckBox";
            this.bluetoothCheckBox.Size = new System.Drawing.Size(110, 17);
            this.bluetoothCheckBox.TabIndex = 13;
            this.bluetoothCheckBox.Text = "Allow Bluetooth";
            this.bluetoothCheckBox.UseVisualStyleBackColor = true;
            this.bluetoothCheckBox.CheckedChanged += new System.EventHandler(this.bluetoothCheckBox_CheckedChanged);
            // 
            // simulateCheckBox
            // 
            this.simulateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simulateCheckBox.AutoSize = true;
            this.simulateCheckBox.Location = new System.Drawing.Point(578, 281);
            this.simulateCheckBox.Name = "simulateCheckBox";
            this.simulateCheckBox.Size = new System.Drawing.Size(93, 17);
            this.simulateCheckBox.TabIndex = 14;
            this.simulateCheckBox.Text = "Simulate GPS";
            this.simulateCheckBox.UseVisualStyleBackColor = true;
            this.simulateCheckBox.CheckedChanged += new System.EventHandler(this.simulateCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 528);
            this.Controls.Add(this.simulateCheckBox);
            this.Controls.Add(this.bluetoothCheckBox);
            this.Controls.Add(this.serialCheckBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cancelDetectButton);
            this.Controls.Add(this.detectButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "GPS.NET 3.0 Diagnostics";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.devicesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.rawDataTab.ResumeLayout(false);
            this.satellitesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private GeoFramework.Gps.Nmea.NmeaInterpreter nmeaInterpreter1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.ListBox sentenceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altitudeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox utcDateTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTimeTextBox;
        private System.Windows.Forms.Button detectButton;
        private System.Windows.Forms.Button cancelDetectButton;
        private System.Windows.Forms.ListView devicesListView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage devicesTab;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.TabPage rawDataTab;
        private System.Windows.Forms.TabPage satellitesTab;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.CheckBox serialCheckBox;
        private System.Windows.Forms.CheckBox bluetoothCheckBox;
        private System.Windows.Forms.TextBox bearingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox simulateCheckBox;
        private System.Windows.Forms.ListView satellitesListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private GeoFramework.Gps.Controls.Speedometer speedometer1;
        private GeoFramework.Gps.Controls.SatelliteViewer satelliteViewer1;
        private GeoFramework.Gps.Controls.Compass compass1;
        private GeoFramework.Gps.Controls.Altimeter altimeter1;
    }
}

