using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _15DemoDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Table 1 Created in Memory - HardCoded Data

            DataTable table = new DataTable("Emp");

            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));

            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            table.PrimaryKey = new DataColumn[] { column1 };


            DataRow row1 = table.NewRow();
            row1[0] = 1;
            row1[1] = "Mahesh";
            row1[2] = "Pune";

            DataRow row2 = table.NewRow();
            row2["No"] = 2;
            row2["Name"] = "Nilesh";
            row2["Address"] = "Chennai";

            DataRow row3 = table.NewRow();
            row3[0] = 3;
            row3[1] = "Chetan";
            row3[2] = "Mumbai";


            table.Rows.Add(row1);
            table.Rows.Add(row2);
            table.Rows.Add(row3);
            #endregion

            #region Table 2 in Memory - Data is Database Table "Test"
            DataTable table2 = new DataTable("Test");

            DataColumn col1 = new DataColumn("ENo", typeof(int));
            DataColumn col2 = new DataColumn("EName", typeof(string));

            table2.Columns.Add(col1);
            table2.Columns.Add(col2);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=punedb;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Test", con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow row = table2.NewRow();
                row[0] = Convert.ToInt32(reader["No"]);
                row[1] = reader["Name"].ToString();

                table2.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            #endregion

            #region Dataset holding many tables 
            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            ds.Tables.Add(table2);

            ds.WriteXml("c:\\Log\\Data.xml");
            ds.WriteXmlSchema("c:\\Log\\DataSchema.xml");
            #endregion
        }
    }
}
