using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace SQLCommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String cs = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\contacts.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True";

            SqlConnection cnn = new SqlConnection(cs);

            cnn.Open();
            String strSql = "SELECT * FROM Contacts";
            SqlCommand cmd = new SqlCommand(strSql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lstbResults.Items.Add(String.Format("{0} {1}", dr["ContactID"], dr["ContactName"]));
            }
            cnn.Close();
        }

        private void lstbResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}