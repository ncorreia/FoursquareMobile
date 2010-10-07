namespace FoursquareApp
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.picture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.friendStatus = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.facebook = new System.Windows.Forms.LinkLabel();
            this.twitterIcon = new System.Windows.Forms.PictureBox();
            this.facebookIcon = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(4, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 100);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.Text = "label1";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(111, 28);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.Text = "label1";
            // 
            // friendStatus
            // 
            this.friendStatus.Location = new System.Drawing.Point(4, 111);
            this.friendStatus.Name = "friendStatus";
            this.friendStatus.Size = new System.Drawing.Size(121, 20);
            this.friendStatus.Text = "label1";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(31, 147);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(100, 20);
            this.twitter.TabIndex = 7;
            this.twitter.Text = "linkLabel1";
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(31, 186);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(180, 25);
            this.facebook.TabIndex = 8;
            this.facebook.Text = "linkLabel2";
            // 
            // twitterIcon
            // 
            this.twitterIcon.Location = new System.Drawing.Point(0, 147);
            this.twitterIcon.Name = "twitterIcon";
            this.twitterIcon.Size = new System.Drawing.Size(25, 25);
            // 
            // facebookIcon
            // 
            this.facebookIcon.Location = new System.Drawing.Point(0, 186);
            this.facebookIcon.Name = "facebookIcon";
            this.facebookIcon.Size = new System.Drawing.Size(25, 25);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(110, 48);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(127, 36);
            this.email.TabIndex = 11;
            this.email.Text = "linkLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.email);
            this.Controls.Add(this.facebookIcon);
            this.Controls.Add(this.twitterIcon);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.friendStatus);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "UserForm";
            this.Text = "User info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label friendStatus;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.LinkLabel facebook;
        private System.Windows.Forms.PictureBox twitterIcon;
        private System.Windows.Forms.PictureBox facebookIcon;
        private System.Windows.Forms.LinkLabel email;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}