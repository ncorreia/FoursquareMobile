namespace FoursquareApp
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.foursquareLogo = new System.Windows.Forms.PictureBox();
            this.foursquareLetters = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // foursquareLogo
            // 
            this.foursquareLogo.Image = ((System.Drawing.Image)(resources.GetObject("foursquareLogo.Image")));
            this.foursquareLogo.Location = new System.Drawing.Point(42, 31);
            this.foursquareLogo.Name = "foursquareLogo";
            this.foursquareLogo.Size = new System.Drawing.Size(150, 150);
            // 
            // foursquareLetters
            // 
            this.foursquareLetters.Image = ((System.Drawing.Image)(resources.GetObject("foursquareLetters.Image")));
            this.foursquareLetters.Location = new System.Drawing.Point(33, 187);
            this.foursquareLetters.Name = "foursquareLetters";
            this.foursquareLetters.Size = new System.Drawing.Size(180, 48);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.foursquareLetters);
            this.Controls.Add(this.foursquareLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "SplashForm";
            this.Text = "FoursquareMobile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox foursquareLogo;
        private System.Windows.Forms.PictureBox foursquareLetters;
    }
}