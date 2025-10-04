using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Text = "Tourist Guide - Main Menu";
            Size = new Size(420, 250);
            StartPosition = FormStartPosition.CenterScreen;

            var btnSlide = new Button { Text = "Slideshow + Description", Location = new Point(30, 30), Size = new Size(340, 40) };
            var btnVideo = new Button { Text = "Video + Details", Location = new Point(30, 85), Size = new Size(340, 40) };
            var btnTours = new Button { Text = "Tours & Prices", Location = new Point(30, 140), Size = new Size(340, 40) };

            btnSlide.Click += (s, e) => new FormSlideshow().Show();
            btnVideo.Click += (s, e) => new FormVideo().Show();
            btnTours.Click += (s, e) => new FormTours().Show();

            Controls.AddRange(new Control[] { btnSlide, btnVideo, btnTours });
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
