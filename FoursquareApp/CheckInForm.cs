using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Foursquare;

namespace FoursquareApp
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        public void LoadVenue(Venue venue)
        {
            venueName.Text = venue.Name;
            this.venue = venue;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            CheckInInfo info = FoursquareAPI.CheckIn(venue.Id, null, shoutMsg.Text, pvt.Checked, twitter.Checked, facebook.Checked,
                venue.Coordinates.Latitude, venue.Coordinates.Longitude);
            CheckedInForm checkedInForm = new CheckedInForm();
            checkedInForm.LoadInfo(info);
            checkedInForm.ShowDialog();
            this.Close();
        }

        private Venue venue;
    }
}