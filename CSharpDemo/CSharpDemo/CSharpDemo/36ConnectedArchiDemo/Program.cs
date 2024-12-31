using System.Data;
using Microsoft.Data.SqlClient;

namespace _36ConnectedArchiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn column1 = new DataColumn("Id",typeof(int));
            DataColumn column2 = new DataColumn("Name",typeof(string));
            DataColumn column3 = new DataColumn("LastName",typeof(string)); 
            DataColumn column4 = new DataColumn("Mark",typeof (int));
            DataColumn column5 = new DataColumn("Address",typeof(string));

            dataTable.Columns.Add(column1);
            dataTable.Columns.Add(column2);
            dataTable.Columns.Add(column3);
            dataTable.Columns.Add(column4);
            dataTable.Columns.Add(column5);
            dataTable.PrimaryKey = new DataColumn[] { column1 };

            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CSharpDatabase;Integrated Security=True;Pooling=False;Trust Server Certificate=False";
            SqlConnection con = new SqlConnection(conStr);
            string query = "select * from student";

            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = Convert.ToInt32(reader["Id"]); 
                row["Name"] = reader["Name"].ToString();
                row["LastName"] = reader["LastName"].ToString();
                row["Mark"] = Convert.ToInt32(reader["Mark"]);
                row["Address"] = reader.ToString();

                dataTable.Rows.Add(row);

            }
            con.Close();
            dataSet.Tables.Add(dataTable);
            dataSet.WriteXml(@"C:\Users\IET\Desktop\67 & 49\.NET\CSharpDemo\CSharpDemo\CSharpDemo\36ConnectedArchiDemo\bin\Debug\net6.0\Select XML\Student.xml");
            
        }
    }
}
