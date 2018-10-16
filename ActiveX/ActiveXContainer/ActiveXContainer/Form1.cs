using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AxSHDocVw;

namespace ActiveXContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AxWebBrowser AxWebBrowser1 = new AxWebBrowser();
            AxWebBrowser1.BeginInit();
            AxWebBrowser1.Size = new System.Drawing.Size(292, 273);
            AxWebBrowser1.TabIndex = 0;
            AxWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(AxWebBrowser1);
            AxWebBrowser1.EndInit();
            AxWebBrowser1.Navigate("www.cnn.com");
        }
    }
}