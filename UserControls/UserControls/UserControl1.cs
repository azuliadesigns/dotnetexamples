using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
        public String LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public String TextBoxText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public String ButtonText
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
    }
}
