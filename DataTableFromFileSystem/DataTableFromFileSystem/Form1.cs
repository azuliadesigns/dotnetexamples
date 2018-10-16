using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataTableFromFileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("DataTableFromFileSystem");
            dt.Columns.Add("FileName", Type.GetType("System.String"));
            dt.Columns.Add("FileSize", Type.GetType("System.Int64"));
            DataRow dr;
            DirectoryInfo di = new DirectoryInfo("c:\\");
            foreach (FileInfo fi in di.GetFiles())
            {
                dr = dt.NewRow();
                dr[0] = fi.Name;
                dr[1] = fi.Length;
                dt.Rows.Add(dr);
            }
            dataGridView.DataSource = dt;
        }
    }
}