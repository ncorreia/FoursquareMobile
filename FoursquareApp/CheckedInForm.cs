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
    public partial class CheckedInForm : Form
    {
        public CheckedInForm()
        {
            InitializeComponent();
        }

        internal void LoadInfo(CheckInInfo info)
        {
            this.info = info;
            venueName.Text = info.Venue.Name;
            message.Text = info.Message;
            mayorMsg.Text = info.Mayor != null ? info.Mayor.Message : "";

            if (info.Mayor != null && info.Mayor.User != null && !string.IsNullOrEmpty(info.Mayor.User.Photo))
            {
                string url = info.Mayor.User.Photo;
                HttpWebRequest imgRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse imgResponse = (HttpWebResponse)imgRequest.GetResponse();
                Bitmap bmp = new Bitmap(imgResponse.GetResponseStream());
                imgResponse.Close();
                userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                userPicture.Image = bmp;
            }
        }

        private CheckInInfo info;
    }
}