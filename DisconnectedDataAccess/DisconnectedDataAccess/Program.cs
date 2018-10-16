using System;
using System.Data;
using System.Data.SqlClient;

class DisconnectedDataAccessExample
{
    static void MyPrintDataSet(DataSet ds)
    {
        foreach (DataTable dt in ds.Tables)
        {
            Console.WriteLine("Table: {0}", dt.TableName);
            foreach (DataColumn dc in dt.Columns)
                Console.Write(" -{0}- ", dc.ColumnName);
            Console.WriteLine();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                    Console.Write(" -{0}- ", dr[dc.Ordinal]);
                Console.WriteLine();
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("DisconnectedDataAccess Example:\n");

        string dsn = "server=.;trusted_connection=yes;database=pubs";
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(
            "SELECT au_id, au_fname, au_lname FROM Authors;select * from Publishers", dsn);
        da.Fill(ds, "Authors"); //Authors will be name of DataTable in DataSet
        ds.Tables[1].TableName = "Publishers";

        DataTable tb = new DataTable("student");
        ds.Tables.Add(tb);
        tb.Columns.Add("name", typeof(string));
        tb.Columns.Add("gpa", typeof(float));

        tb.Rows.Add(new object[] { "Bob", 4.0 });
        tb.Rows.Add(new object[] { "Alice", 3.6 });
        tb.Rows.Add(new object[] { "Joe", 4.0 });
        tb.Rows.Add(new object[] { "Fred", 3.0 });

        DataView myDataView = new DataView(ds.Tables["authors"]);
        myDataView.Sort = "au_lname DESC";
        myDataView.RowFilter = "au_fname LIKE 'M%'";
        myDataView.AllowDelete = false;

        MyPrintDataSet(ds);

        ds.Tables[0].Columns[0].ColumnMapping = MappingType.Attribute;
        ds.WriteXmlSchema(@"..\..\data.xsd");
        ds.WriteXml(@"..\..\data.xml");
    }
}
