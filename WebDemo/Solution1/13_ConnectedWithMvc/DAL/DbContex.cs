using _13ConnectedWithMvc.Model;
using Microsoft.Data.SqlClient;

namespace _13ConnectedWithMvc.DAL
{
    public class DbContex
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CSharpDatabase;Integrated Security=True;Pooling=False;Trust Server Certificate=False";

        public List<Emp> GetAllEmps()
        {
            List<Emp> list = new List<Emp>();
            SqlConnection sqlConnection = new SqlConnection(conStr);
            string query = "select * from Employees";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.Id= Convert.ToInt32(reader["EId"]);
                emp.Name = reader["EName"].ToString();
                emp.Address = reader["EAddress"].ToString();
                list.Add(emp);
            }
            sqlConnection.Close();
            return list;
        }
    }
}




