using System;
using System.Windows.Forms;
using GeoFramework.Gps.IO;
using GeoFramework.Gps.Nmea;
using CellId;
using GoogleMaps;
using OpenCellId;
using Foursquare;
using System.Threading;

namespace FoursquareApp
{
    public partial class MainForm0 : Form
    {
        private NmeaInterpreter nmea;
        private delegate void SetVisibleDelegate();

        public MainForm0()
        {
            this.Visible = false;
            InitializeComponent();

            ThreadPool.QueueUserWorkItem(delegate(object state)
            {
                SplashForm splash = new SplashForm();
                splash.ShowDialog();
                this.Invoke(new SetVisibleDelegate(SetVisible));
            });
        }

        private void SetVisible()
        {
            this.Visible = true;
        }

        private void initGps_Click(object sender, EventArgs e)
        {
            Devices.PositionChanged += new EventHandler<GeoFramework.PositionEventArgs>(Devices_PositionChanged);
            nmea = new NmeaInterpreter();
            nmea.PositionChanged += new EventHandler<GeoFramework.PositionEventArgs>(Devices_PositionChanged);
            nmea.Start();
            MessageBox.Show("Waiting for signal...");
        }

        void Devices_PositionChanged(object sender, GeoFramework.PositionEventArgs e)
        {
            locationLabel.Text = nmea.Position.ToString();
        }

        private void getCellIdLocation_Click(object sender, EventArgs e)
        {
            string cellInfo = RIL.GetCellTowerInfo();
            string[] cellInfoParts = cellInfo.Split('-');
            string[] args = { 
                cellInfoParts[2], // MCC 
                "0",              // MNC – don’t need it here
                cellInfoParts[1], // LAC
                cellInfoParts[0]  // CID
            };

            string latlng = openCellId.Checked ? OCI.GetCoordinates(cellInfo) : GMM.GetLatLng(args);
            locationLabel.Text = latlng;
        }

        private void getVenues_Click(object sender, EventArgs e)
        {
            try
            {
                string[] coordinatesParts = locationLabel.Text.Split(';');
                if (coordinatesParts.Length <= 1)
                {
                    coordinatesParts = locationLabel.Text.Split(',');
                }
                Venue[] venuesArray = FoursquareAPI.GetVenues(
                    double.Parse(coordinatesParts[0].Trim()), double.Parse(coordinatesParts[1].Trim()), shout.Text);

                venues.DataSource = venuesArray;
                venues.DisplayMember = "Name";
                venues.ValueMember = "Id";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] coordinatesParts = locationLabel.Text.Split(';');
                CheckInInfo info = FoursquareAPI.CheckIn((long)venues.SelectedValue, "", shout.Text, pvt.Checked, twitter.Checked,
                    facebook.Checked, double.Parse(coordinatesParts[0].Trim()), double.Parse(coordinatesParts[1].Trim()));
                MessageBox.Show((info.Message ?? "") + Environment.NewLine + ((info.Mayor != null && info.Mayor.Message != null) ? 
                    ("Mayorship: " + info.Mayor.Message) : ""));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(venues.Items[venues.SelectedIndex].ToString());
            VenueForm venueForm = new VenueForm();
            venueForm.LoadVenue(Venue.GetVenue((venues.Items[venues.SelectedIndex] as Venue).Id));
            venueForm.ShowDialog();
        }
    }
}