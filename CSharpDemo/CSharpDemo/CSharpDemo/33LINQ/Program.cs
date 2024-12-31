using System.Security.Cryptography.X509Certificates;

namespace _33LINQ
{
    internal class Program
    {
        public delegate bool MyDelegate(Emp emp, string city);
        static void Main(string[] args)
        {
            List<Emp> employees = new List<Emp>() {
                new Emp(){Id = 11, Name="Ganesh", Address="Pune"},
                new Emp(){Id = 12, Name="Gajanan", Address="Punjab"},
                new Emp(){Id = 13, Name="Divyansh", Address="Mumbai"},
                new Emp(){Id = 14, Name="Anup", Address="Pune"},
                new Emp(){Id = 15, Name="Deepali", Address="Patna"},
                new Emp(){Id = 16, Name="Aman", Address="Manipur"},
                new Emp(){Id = 17, Name="Gunjan", Address="Pune"},
                new Emp(){Id = 18, Name="Abhiraj", Address="Indore"},
                new Emp(){Id = 19, Name="Aishwarya", Address="Kolhapur"}
            };
            List<Student> students = new List<Student>()
            {
                new Student(){Sid = 11, Sname="Ganesh", Saddress="Pune",Mark=90},
                new Student(){Sid = 12, Sname="Gajanan", Saddress="Punjab",Mark=78},
                new Student(){ Sid= 13, Sname="Riya", Saddress="Nashik",Mark=90},
                new Student(){Sid = 15, Sname="xyz", Saddress="Punjab",Mark=78},


            };


            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine();

            #region Conventional Method

            //var FilteredCollection = new List<Emp>();

            //foreach (Emp emp in employees)
            //{
            //    if (emp.Address.ToUpper() == city.ToUpper())
            //    {
            //        FilteredCollection.Add(emp);
            //    }
            //}

            //foreach (Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address} ");
            //} 
            #endregion

            #region Conventional method student class
            //var FilterCollection = new List<Student>();
            //  foreach (Student student in students)
            //{
            //    if(student.Saddress.ToLower()== city.ToLower())
            //    {
            //        FilterCollection.Add(student);
            //        //Console.WriteLine($"{student.Sid},{student.Sname},{student.Mark}");
            //    }
            //}
            //foreach (Student student in FilterCollection)
            //{
            //    Console.WriteLine($"ID={student.Sid},Name={student.Sname},Mark={student.Mark}");
            //}
            #endregion

            #region Using LINQ Query
            //var FilteredCollection = (from emp in employees where emp.Address.ToLower() == city.ToLower() select emp).ToList();
            //foreach (Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address} ");
            //} 
            #endregion

            #region Using Holder to Return Multiple Values
            //var FilteredCollection = (from emp in employees where emp.Address == city select new Holder()
            //{
            //    HName = emp.Name,
            //    HAddress = emp.Address,
            //}).ToList();

            //foreach (Holder emp in FilteredCollection) {
            //    Console.WriteLine($"Name : {emp.HName}, Address : {emp.HAddress} ");
            //} 
            #endregion

            #region Using Anonymous Type to Return Multiple Values
            //var FilteredCollection = (from emp in employees select new { Name = emp.Name, Address = emp.Address}).ToList();
            //foreach (var item in FilteredCollection)
            //{
            //    Console.WriteLine($"Name : {item.Name}, Address : {item.Address}");
            //} 
            #endregion

            #region Using Delegate For Where Condition
            MyDelegate pointer = new MyDelegate(CheckCondition);

            var FilteredCollection = new List<Emp>();
            foreach (Emp emp in employees)
            {
                if (pointer(emp, city))
                {
                    FilteredCollection.Add(emp);
                }
            }

            foreach (Emp emp in FilteredCollection)
            {
                Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address} ");
            } 
            #endregion
        }

        public static bool CheckCondition(Emp emp, string city)
        {
            return (emp.Address.ToLower() == city.ToLower());
        }

        
    }

    public class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    }

    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

    }
    public class Student
    {
        private string _sname;
        private string _saddress;
        private int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }


        public string Saddress
        {
            get { return _saddress; }
            set { _saddress = value; }
        }





        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }

        private int _sid;

        public int Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

    }

}
