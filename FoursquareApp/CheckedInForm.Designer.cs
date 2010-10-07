namespace FoursquareApp
{
    partial class CheckedInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckedInForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mayorMsg = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.venueName = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mayorMsg
            // 
            this.mayorMsg.Location = new System.Drawing.Point(66, 118);
            this.mayorMsg.Name = "mayorMsg";
            this.mayorMsg.Size = new System.Drawing.Size(171, 58);
            this.mayorMsg.Text = "label1";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(3, 61);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(220, 42);
            this.message.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.Text = "We\'ve got you @ ";
            // 
            // venueName
            // 
            this.venueName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.venueName.Location = new System.Drawing.Point(119, 4);
            this.venueName.Name = "venueName";
            this.venueName.Size = new System.Drawing.Size(120, 20);
            this.venueName.Text = "label4";
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(4, 118);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(50, 50);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // CheckedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.venueName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message);
            this.Controls.Add(this.mayorMsg);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "CheckedInForm";
            this.Text = "Checked In!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mayorMsg;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label venueName;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}