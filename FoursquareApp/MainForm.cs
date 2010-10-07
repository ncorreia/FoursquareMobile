using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Foursquare;

namespace FoursquareApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CheckIn[] checkins = FoursquareAPI.GetLastFriendsCheckIns();
            int checkinsShown = 0;
            foreach (CheckIn checkin in checkins)
            {
                TimeSpan elapsedTime = DateTime.Now.Subtract(checkin.Created);
                string timeStr = "";
                if (elapsedTime.TotalSeconds < 60)
                {
                    timeStr = (int)elapsedTime.TotalSeconds + " seconds ago";
                }
                else if (elapsedTime.TotalMinutes < 60)
                {
                    timeStr = (int)elapsedTime.TotalMinutes + " minutes ago";
                }
                else if (elapsedTime.TotalHours < 24)
                {
                    timeStr = (int)elapsedTime.TotalHours + " hours ago";
                }
                else
                {
                    timeStr = (int)elapsedTime.TotalDays + " days ago";
                }
                ListViewItem item = new ListViewItem(checkin.User.FirstName + " " + checkin.User.LastName + " @ " +
                    checkin.Venue.Name + " (" + timeStr + ")");
                lastFriendsCheckIns.Items.Add(item);
                if (++checkinsShown >= 5)
                {
                    break;
                }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            MainForm0 oldMain = new MainForm0();
            oldMain.ShowDialog();
        }

        private void lastFriendsCheckIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lastFriendsCheckIns.SelectedIndices.Count > 0)
            {
                MessageBox.Show(lastFriendsCheckIns.Items[lastFriendsCheckIns.SelectedIndices[0]].Text);
                lastFriendsCheckIns.Items[lastFriendsCheckIns.SelectedIndices[0]].Selected = false;
            }
        }
    }
}