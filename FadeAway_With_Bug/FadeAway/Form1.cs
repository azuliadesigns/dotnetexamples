using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FadeAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity < 0.05)
                okToClose = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!okToClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
        }
        private bool okToClose = false;
    }
}