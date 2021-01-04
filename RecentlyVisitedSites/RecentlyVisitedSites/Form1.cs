using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecentlyVisitedSites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.link2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.link2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.instagram.com");
        }

        private void link3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.link3.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.twitter.com");
        }

        private void link1_MouseHover(object sender, EventArgs e)
        {
            link1.Text = "Facebook is a popular free social networking website that allows registered users to create profiles, upload photos and video, send messages and keep in touch with friends, family and colleagues.";
        }

        private void link2_MouseHover(object sender, EventArgs e)
        {
            link2.Text = "Instagram is a photo and video-sharing social networking service owned by Facebook, Inc. The app allows users to upload photos and videos to the service, which can be edited with various filters, and organized with tags and location information.";
        }

        private void link3_MouseHover(object sender, EventArgs e)
        {
            link3.Text = "Twitter is an online news and social networking service on which users post and interact with messages known as tweets. Tweets were originally restricted to 140 characters";
        }

        private void link1_MouseLeave(object sender, EventArgs e)
        {
            link1.Text = "Facebook";
        }

        private void link2_MouseLeave(object sender, EventArgs e)
        {
            link2.Text = "Instagram";
        }

        private void link3_MouseLeave(object sender, EventArgs e)
        {
            link3.Text = "Twitter";
        }

    }
}
