using System.Reflection;
using _27DBLib;

namespace _28SQLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string AssemblyPath = @"C:\Users\IET\Desktop\67 & 49\.NET\CSharpDemo\CSharpDemo\CSharpDemo\26Emp\bin\Debug\net6.0\26Emp.dll";
            Assembly asm = Assembly.LoadFrom(AssemblyPath);
            Type[] types = asm.GetTypes();
            string MysqlQurey = "Create Table ";
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                if (type.IsPublic)
                {
                    Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                    for (int j = 0; j < allAttributes.Length; j++)
                    {
                        Attribute attributeofClasses = allAttributes[j];
                        if (attributeofClasses is Table)
                        {
                            Table table = attributeofClasses as Table;
                            MysqlQurey = MysqlQurey + table.TableName + " (";


                        }
                    }
                    PropertyInfo[] properties = type.GetProperties();
                    for (int j = 0; j < properties.Length; j++)
                    {
                        PropertyInfo property = properties[j];
                        Attribute[] attributes = property.GetCustomAttributes().ToArray();
                        for (int k = 0; k < attributes.Length; k++)
                        {
                            Attribute attributeofClasses = attributes[k];
                            Column column = attributeofClasses as Column;
                            MysqlQurey = MysqlQurey + column.ColumnName + " " + column.ColumnType + ",";
                            Console.WriteLine(MysqlQurey);
                        }
                    }
                    //create table emp(id int ,name varchar(20),address varchar(20));
                }
            }
            MysqlQurey = MysqlQurey.TrimEnd(',') + ");";
            Console.WriteLine(MysqlQurey);
            string filepath = @"C:\Users\IET\Desktop\67 & 49\.NET\CSharpDemo\CSharpDemo\CSharpDemo\28SQLDemo\bin\Debug\net6.0\demo.sql";
            using (StreamWriter sw = File.CreateText(filepath)) 
            {


                sw.WriteLine(MysqlQurey);
                Console.WriteLine("Query writting Done!");




            }
        }
    }
}
