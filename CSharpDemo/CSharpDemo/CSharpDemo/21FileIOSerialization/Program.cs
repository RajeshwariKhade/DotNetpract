using System.Text.Json;

namespace _21FileIOSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region filewriteMode
            //Console.WriteLine("Hello, World!");
            //string filePath = "C:\\Users\\IET\\Desktop\\67 & 49\\.NET\\CSharpDemo\\CSharpDemo\\CSharpDemo\\demo.txt";
            //string filePath = "C:\\Users\\IET\\Desktop\\67 & 49\\.NET\\CSharpDemo\\CSharpDemo\\CSharpDemo\\22demo\\demo1.json";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //}
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Enter some data Enter into .txt file");
            //string inputstring = Console.ReadLine();
            //writer.WriteLine(inputstring);
            //writer.Flush();
            //writer.Close();
            //Console.WriteLine("Done");
            #endregion
            #region ReadMode
            //string filePath = "C:\\Users\\IET\\Desktop\\67 & 49\\.NET\\CSharpDemo\\CSharpDemo\\CSharpDemo\\22demo\\demo1.json";
            // FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //}
            //else
            //{
            //    Console.WriteLine("File not Exites ");

            //}
            //StreamReader reader = new StreamReader(fs);
            //string resultreader = reader.ReadToEnd();
            //reader.Close();
            //Console.WriteLine(resultreader);
            //fs.Close(); 
            #endregion
            #region access class object
            //string filepath = "C:\\Users\\IET\\Desktop\\67 & 49\\.NET\\CSharpDemo\\CSharpDemo\\CSharpDemo\\21FileIOSerialization\\EmpData.txt";
            //FileStream fs = null;
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            //}
            //StreamWriter writer = new StreamWriter(fs);
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp name");
            //emp.Ename = Console.ReadLine();
            //Console.WriteLine("Enter Emp address");
            //Console.ReadLine();
            //writer.Write(emp);
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done ");
            #endregion
            #region JsonSerialization
            string filePath = "C:\\Users\\IET\\Desktop\\67 & 49\\.NET\\CSharpDemo\\CSharpDemo\\CSharpDemo\\21FileIOSerialization\\Emp1.json";
            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }
            Emp emp = new Emp();

            Console.WriteLine("Enter Emp NAme");
            emp.Ename = Console.ReadLine();
            Console.WriteLine("Enter Emp Address");
            emp.Address = Console.ReadLine();

            //Pen
            JsonSerializer.Serialize(emp);

            fs.Close();
            Console.WriteLine("Done !");

            #endregion

            #region JSOn Deserializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}
            ////Pen
            //Emp emp = JsonSerializer.Deserialize<Emp>(fs);
            //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

            //fs.Close();
            #endregion
            #region XML Serializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp Id");
            //emp.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Emp NAme");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Emp Address");
            //emp.Address = Console.ReadLine();

            //Book book = new Book();
            //book.BookName = "Let us C++";

            //ArrayList arr = new ArrayList();
            //arr.Add(emp);
            //arr.Add(book);

            //Pen
            //int i = 10;
            //Console.WriteLine(i.GetType().ToString());
            //Console.WriteLine(emp.GetType().ToString());
            //Type[] types = new Type[arr.Count];
            //types[0] = typeof(Emp);
            //types[1] = typeof(Book);
            //XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), types);
            //xs.Serialize(fs, arr);
            //fs.Close();
            Console.WriteLine("Done !");
            #endregion
            #region XMl Deserializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}

            ////Pen
            //Type[] types = new Type[2];
            //types[0] = typeof(Emp);
            //types[1] = typeof(Book);
            //XmlSerializer xs = new XmlSerializer(typeof(ArrayList),types);
            //ArrayList arr = xs.Deserialize(fs) as ArrayList;
            //foreach (var item in arr)
            //{
            //    if(item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address ={emp.Address}");
            //    }
            //    if(item is Book)
            //    {
            //         Book book = item as Book;
            //        Console.WriteLine($"Book Name = {book.BookName}");
            //    }
            //}
            //fs.Close();
            #endregion
            #region Binary Deserialize
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}
            ////Pen
            //BinaryFormatter bf = new BinaryFormatter();
            //Emp emp = bf.Deserialize(fs) as Emp;
            //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

            //fs.Close();
            #endregion










        }

    }
    #region Empclass
    public class Emp
    {
        private string _Ename;
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

    }
    #endregion
    #region Book

    public class Book
    {
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

    }

    #endregion
}
