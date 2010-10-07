namespace FoursquareApp
{
    partial class CheckInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.venueName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shoutMsg = new System.Windows.Forms.TextBox();
            this.pvt = new System.Windows.Forms.CheckBox();
            this.twitter = new System.Windows.Forms.CheckBox();
            this.facebook = new System.Windows.Forms.CheckBox();
            this.checkIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "You\'re @ ";
            // 
            // venueName
            // 
            this.venueName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.venueName.Location = new System.Drawing.Point(83, 4);
            this.venueName.Name = "venueName";
            this.venueName.Size = new System.Drawing.Size(100, 20);
            this.venueName.Text = "label2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Shout a message";
            // 
            // shoutMsg
            // 
            this.shoutMsg.Location = new System.Drawing.Point(4, 64);
            this.shoutMsg.Name = "shoutMsg";
            this.shoutMsg.Size = new System.Drawing.Size(233, 21);
            this.shoutMsg.TabIndex = 3;
            // 
            // pvt
            // 
            this.pvt.Location = new System.Drawing.Point(4, 119);
            this.pvt.Name = "pvt";
            this.pvt.Size = new System.Drawing.Size(100, 20);
            this.pvt.TabIndex = 7;
            this.pvt.Text = "Private";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(4, 146);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(121, 20);
            this.twitter.TabIndex = 8;
            this.twitter.Text = "Send to twitter";
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(4, 173);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(160, 20);
            this.facebook.TabIndex = 9;
            this.facebook.Text = "Send to facebook";
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(4, 224);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(72, 20);
            this.checkIn.TabIndex = 10;
            this.checkIn.Text = "Check in!";
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.pvt);
            this.Controls.Add(this.shoutMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.venueName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "CheckInForm";
            this.Text = "Checking in...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label venueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shoutMsg;
        private System.Windows.Forms.CheckBox pvt;
        private System.Windows.Forms.CheckBox twitter;
        private System.Windows.Forms.CheckBox facebook;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}