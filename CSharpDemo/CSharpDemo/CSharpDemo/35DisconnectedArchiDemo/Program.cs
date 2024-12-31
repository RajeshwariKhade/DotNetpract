using System.Data;
using Microsoft.Data.SqlClient;

namespace _35DisconnectedArchiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CSharpDatabase;Integrated Security=True;Pooling=False;Trust Server Certificate=False";
            SqlConnection con = new SqlConnection(conStr);
            #region Select Query
            string selectQuery = "select * from student";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"ID : {row["Id"]}, Name : {row["Name"]}, Last Name : {row["LastName"]}, Mark : {row["Mark"]}, Address : {row["Address"]}");
            }
            #endregion

            #region Insert Into Query
            //string name = "abcd";
            //string lname = "efgh";
            //int mark = 55;
            //string add = "kop";

            //DataRow dr = dt.NewRow();
            //dr["Id"] = 3;
            //dr["Name"] = name;
            //dr["LastName"] = lname;
            //dr["Mark"] = mark;
            //dr["Address"] = add;

            //dt.Rows.Add(dr);
            //da.Update(dt);
            #endregion

            #region Update Query
            //Console.WriteLine("Enter Student ID");
            //int id = Convert.ToInt32(Console.ReadLine());
            //DataRow data = dt.Rows.Find(id);
            //string name1 = "xyz";
            //string lname1 = "pqr";
            //int mark1 = 55;
            //string add1 = "kop";
            //data["Name"] = name1;
            //data["LastName"] = lname1;
            //data["Mark"] = mark1;
            //data["Address"] = add1;

            //da.Update(dt);

            //Console.WriteLine("Updation Successfull"); 
            #endregion

            #region Delete Query
            Console.WriteLine("Enter Student ID");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow dr = dt.Rows.Find(id);
            dr.Delete();
            da.Update(dt);
            Console.WriteLine("Deleted Successfully"); 
            #endregion


        }
    }
}
