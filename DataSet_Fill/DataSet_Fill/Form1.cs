using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DataSet_Fill
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

            String strSql = "SELECT * FROM Contacts";
            SqlDataAdapter da = new SqlDataAdapter(strSql, cs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResults.DataSource = dt;
        }

    }
}