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
using System.IO;
using System.Reflection;

namespace FoursquareApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        internal void LoadUser(User user)
        {
            this.user = user;
            name.Text = user.FirstName + " " + user.LastName;
            gender.Text = user.Gender.ToString();
            email.Text = user.Email;
            twitter.Text = string.IsNullOrEmpty(user.Twitter) ? "" :  "@" + user.Twitter;
            facebook.Text = string.IsNullOrEmpty(user.Facebook) ? "" : "http://www.facebook.com/profile.php?id=" + user.Facebook;
            friendStatus.Text = user.FriendStatus;

            if (!string.IsNullOrEmpty(user.Photo))
            {
                string url = user.Photo;
                HttpWebRequest imgRequest = (HttpWebRequest)WebRequest.Create(url);
                imgRequest.Method = "GET";
                HttpWebResponse imgResponse = (HttpWebResponse)imgRequest.GetResponse();
                Bitmap bmp = new Bitmap(imgResponse.GetResponseStream());
                imgResponse.Close();
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = bmp;
            }
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FoursquareApp.Icons.twitter.gif");
            twitterIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            twitterIcon.Image = new Bitmap(stream);

            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FoursquareApp.Icons.facebook.jpg");
            facebookIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            facebookIcon.Image = new Bitmap(stream); 
        }

        private User user;
    }
}