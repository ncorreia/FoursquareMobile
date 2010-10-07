using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Foursquare;
using System.Net;

namespace FoursquareApp
{
    public partial class VenueForm : Form
    {
        public VenueForm()
        {
            InitializeComponent();
        }

        public void LoadVenue(Venue venue)
        {
            this.venue = venue;
            name.Text = venue.Name;
            address.Text = venue.Address;
            zipCode.Text = venue.ZipCode;
            cityState.Text = venue.City + ", " + venue.State;
            phone.Text = venue.Phone;
            twitter.Text = venue.Twitter != null ? "@" + venue.Twitter : "";
            //System.Diagnostics.Process.Start("http://twitter.com/" + venue.Twitter);

            string url = string.Format("http://services.sapo.pt/Maps/GetMapByRadius?latitude={0}&longitude={1}&radius=400&width={2}&height={3}&pointLatitude={0}&pointLongitude={1}",
                venue.Coordinates.Latitude, venue.Coordinates.Longitude, mapImage.Width, mapImage.Height);
            HttpWebRequest imgRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse imgResponse = (HttpWebResponse)imgRequest.GetResponse();
            Bitmap bmp = new Bitmap(imgResponse.GetResponseStream());
            imgResponse.Close();
            mapImage.Image = bmp;

            if (venue.Mayor != null && venue.Mayor.User != null)
            {
                if (!string.IsNullOrEmpty(venue.Mayor.User.Photo))
                {
                    url = venue.Mayor.User.Photo;
                    imgRequest = (HttpWebRequest)WebRequest.Create(url);
                    imgResponse = (HttpWebResponse)imgRequest.GetResponse();
                    bmp = new Bitmap(imgResponse.GetResponseStream());
                    imgResponse.Close();
                    mayorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    mayorPicture.Image = bmp;
                }
                mayorName.Text = venue.Mayor.User.FirstName + " " + venue.Mayor.User.LastName;
            }
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.LoadVenue(venue);
            checkInForm.ShowDialog();
        }

        private void mayorPicture_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.LoadUser(User.GetUser(venue.Mayor.User.Id));
            userForm.ShowDialog();
        }

        private Venue venue;

    }
}
