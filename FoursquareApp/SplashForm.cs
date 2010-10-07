using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace FoursquareApp
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            //Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FoursquareApp.Icons.foursquare-medium.jpg");
            //foursquareLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            //foursquareLogo.Image = new Bitmap(stream);

            //stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FoursquareApp.Icons.foursquare-letters.png");
            //foursquareLetters.SizeMode = PictureBoxSizeMode.StretchImage;
            //foursquareLetters.Image = new Bitmap(stream);

            this.Load += new EventHandler(SplashForm_Load);
        }

        void SplashForm_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate(object state)
            {
                Form form = state as Form;
                Thread.Sleep(2500);
                form.Invoke(new CloseDelegate(Close));
            }, this);
        }

        private delegate void CloseDelegate();
    }
}