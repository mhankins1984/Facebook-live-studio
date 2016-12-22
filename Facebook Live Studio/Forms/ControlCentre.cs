﻿using System;
using System.Windows.Forms;

namespace Facebook_Live_Studio.Forms
{
    public partial class ControlCentre : Form
    {
        public ControlCentre()
        {
            InitializeComponent();
        }

        private void ControlCentre_Load(object sender, EventArgs e)
        {
            var Authorise = new Authorise();
            Authorise.ShowDialog(this);

            if (Authorise.UserAccessToken == null) // Checks if AccessToken null
            {
                this.Close(); // Terminates application if AccessToken null
            }

            var Selectpage = new Selectpage();
            Selectpage.ShowDialog(this);

            PageNameLabel.Text = Selectpage.PageTitle; // Displays page name
        }

        private void Schedulelivevideo_Click(object sender, EventArgs e)
        {
            var Schedulelivevideo = new Schedulelivevideo();
            Schedulelivevideo.ShowDialog(this);
        }

        private void VideocommentsButton_Click(object sender, EventArgs e)
        {
            var Comments = new Videocomments();
            Comments.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Videoselector = new Videoselector();
            Videoselector.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Streampreview = new Streampreview ();
            Streampreview.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Selectpage = new Selectpage();
            Selectpage.ShowDialog(this);

        }
    }
}