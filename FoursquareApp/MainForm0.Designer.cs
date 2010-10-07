namespace FoursquareApp
{
    partial class MainForm0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm0));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.initGps = new System.Windows.Forms.Button();
            this.getCellIdLocation = new System.Windows.Forms.Button();
            this.googleCellId = new System.Windows.Forms.RadioButton();
            this.openCellId = new System.Windows.Forms.RadioButton();
            this.locationLabel = new System.Windows.Forms.Label();
            this.getVenues = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.venues = new System.Windows.Forms.ListBox();
            this.facebook = new System.Windows.Forms.CheckBox();
            this.twitter = new System.Windows.Forms.CheckBox();
            this.pvt = new System.Windows.Forms.CheckBox();
            this.shout = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // initGps
            // 
            this.initGps.Location = new System.Drawing.Point(81, 200);
            this.initGps.Name = "initGps";
            this.initGps.Size = new System.Drawing.Size(72, 20);
            this.initGps.TabIndex = 2;
            this.initGps.Text = "GPS";
            this.initGps.Click += new System.EventHandler(this.initGps_Click);
            // 
            // getCellIdLocation
            // 
            this.getCellIdLocation.Location = new System.Drawing.Point(3, 200);
            this.getCellIdLocation.Name = "getCellIdLocation";
            this.getCellIdLocation.Size = new System.Drawing.Size(72, 20);
            this.getCellIdLocation.TabIndex = 4;
            this.getCellIdLocation.Text = "Get Cell Id";
            this.getCellIdLocation.Click += new System.EventHandler(this.getCellIdLocation_Click);
            // 
            // googleCellId
            // 
            this.googleCellId.Location = new System.Drawing.Point(3, 174);
            this.googleCellId.Name = "googleCellId";
            this.googleCellId.Size = new System.Drawing.Size(100, 20);
            this.googleCellId.TabIndex = 5;
            this.googleCellId.Text = "Google";
            // 
            // openCellId
            // 
            this.openCellId.Location = new System.Drawing.Point(72, 174);
            this.openCellId.Name = "openCellId";
            this.openCellId.Size = new System.Drawing.Size(100, 20);
            this.openCellId.TabIndex = 6;
            this.openCellId.Text = "OpenCellId";
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Location = new System.Drawing.Point(0, 223);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(207, 24);
            this.locationLabel.Text = "Undefined";
            // 
            // getVenues
            // 
            this.getVenues.Location = new System.Drawing.Point(0, 148);
            this.getVenues.Name = "getVenues";
            this.getVenues.Size = new System.Drawing.Size(80, 20);
            this.getVenues.TabIndex = 9;
            this.getVenues.Text = "Get Venues";
            this.getVenues.Click += new System.EventHandler(this.getVenues_Click);
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(115, 148);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(72, 20);
            this.checkIn.TabIndex = 12;
            this.checkIn.Text = "Check in!";
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // venues
            // 
            this.venues.Location = new System.Drawing.Point(4, 3);
            this.venues.Name = "venues";
            this.venues.Size = new System.Drawing.Size(233, 86);
            this.venues.TabIndex = 13;
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(100, 122);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(41, 20);
            this.facebook.TabIndex = 14;
            this.facebook.Text = "F";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(147, 122);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(40, 20);
            this.twitter.TabIndex = 15;
            this.twitter.Text = "T";
            // 
            // pvt
            // 
            this.pvt.Location = new System.Drawing.Point(193, 122);
            this.pvt.Name = "pvt";
            this.pvt.Size = new System.Drawing.Size(36, 20);
            this.pvt.TabIndex = 16;
            this.pvt.Text = "P";
            // 
            // shout
            // 
            this.shout.Location = new System.Drawing.Point(4, 122);
            this.shout.Name = "shout";
            this.shout.Size = new System.Drawing.Size(90, 21);
            this.shout.TabIndex = 17;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(4, 96);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(72, 20);
            this.details.TabIndex = 19;
            this.details.Text = "Details";
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.details);
            this.Controls.Add(this.shout);
            this.Controls.Add(this.pvt);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.venues);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.getVenues);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.openCellId);
            this.Controls.Add(this.googleCellId);
            this.Controls.Add(this.getCellIdLocation);
            this.Controls.Add(this.initGps);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "4sq mobile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initGps;
        private System.Windows.Forms.Button getCellIdLocation;
        private System.Windows.Forms.RadioButton googleCellId;
        private System.Windows.Forms.RadioButton openCellId;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button getVenues;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.ListBox venues;
        private System.Windows.Forms.CheckBox facebook;
        private System.Windows.Forms.CheckBox twitter;
        private System.Windows.Forms.CheckBox pvt;
        private System.Windows.Forms.TextBox shout;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

