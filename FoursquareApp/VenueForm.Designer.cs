namespace FoursquareApp
{
    partial class VenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenueForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.Label();
            this.cityState = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.checkIn = new System.Windows.Forms.Button();
            this.mayorPicture = new System.Windows.Forms.PictureBox();
            this.mayorName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mapImage
            // 
            this.mapImage.Location = new System.Drawing.Point(3, 32);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(233, 102);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(3, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 20);
            this.name.Text = "label1";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(4, 137);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(233, 20);
            this.address.Text = "label1";
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(4, 161);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(58, 20);
            this.zipCode.Text = "label1";
            // 
            // cityState
            // 
            this.cityState.Location = new System.Drawing.Point(69, 161);
            this.cityState.Name = "cityState";
            this.cityState.Size = new System.Drawing.Size(100, 20);
            this.cityState.Text = "label1";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(4, 185);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.Text = "label1";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(4, 209);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(100, 20);
            this.twitter.TabIndex = 6;
            this.twitter.Text = "linkLabel1";
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(4, 233);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(100, 20);
            this.checkIn.TabIndex = 7;
            this.checkIn.Text = "Check in here!";
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // mayorPicture
            // 
            this.mayorPicture.Location = new System.Drawing.Point(187, 185);
            this.mayorPicture.Name = "mayorPicture";
            this.mayorPicture.Size = new System.Drawing.Size(50, 50);
            this.mayorPicture.Click += new System.EventHandler(this.mayorPicture_Click);
            // 
            // mayorName
            // 
            this.mayorName.Location = new System.Drawing.Point(175, 238);
            this.mayorName.Name = "mayorName";
            this.mayorName.Size = new System.Drawing.Size(62, 20);
            this.mayorName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // VenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.mayorName);
            this.Controls.Add(this.mayorPicture);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.cityState);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mapImage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "VenueForm";
            this.Text = "Venue info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapImage;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label zipCode;
        private System.Windows.Forms.Label cityState;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.PictureBox mayorPicture;
        private System.Windows.Forms.Label mayorName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}