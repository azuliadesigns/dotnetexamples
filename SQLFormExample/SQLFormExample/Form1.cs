using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.contactsTableAdapter.Update(this.contactsDataSet.Contacts);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.contactsDataSet.Contacts);

        }
    }
}