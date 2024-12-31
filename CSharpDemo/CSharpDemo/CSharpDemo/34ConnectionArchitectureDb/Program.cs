using Microsoft.Data.SqlClient;

namespace _34ConnectionArchitectureDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CSharpDatabase;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
            #region CURD

            //SqlConnection con = new SqlConnection(constr);
            //string query = "select * from student";
            //SqlCommand cmd = con.CreateCommand();
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int? id = Convert.ToInt32(reader["ID"]);
            //    string Name = Convert.ToString(reader["Name"]);
            //    string LastName = Convert.ToString(reader["LastName"]);
            //    int Mark = Convert.ToInt32(reader["Mark"]);
            //    string Address = Convert.ToString(reader["Address"]);
            //    con.Close();
            //}
            #endregion
            #region InSert
            SqlConnection con = new SqlConnection(constr);
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string? Name =  Console.ReadLine();
            Console.WriteLine("Enter Student LastName");
            string? Lastname = Console.ReadLine();
            Console.WriteLine("Enter student Mark");
            int? Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Address");
            string? Address = Console.ReadLine();
            string? query = $"insert into Student values('{id}','{Name}','{Lastname}','{Mark}','{Address}')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int noRowAffect = cmd.ExecuteNonQuery();
            con.Close();
            if (noRowAffect > 0)
            {
                Console.WriteLine("Record Inserted");
            }

            #endregion
            #region Update
            SqlConnection conn = new SqlConnection(constr);
            Console.WriteLine("Enter name :");
            string? nm = Console.ReadLine();
            Console.WriteLine("Enter name :");
            string? add = Console.ReadLine();

            string querys = $"update Student set Name='{nm}', Address='{add}' ,where Id= 2";
            SqlCommand cmds = new SqlCommand(querys, conn);
            con.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (noOfRowsAffected > 0)
            {
                Console.WriteLine("Record updated into EMp successfully!");
            }
            #endregion


        }
    }
}
