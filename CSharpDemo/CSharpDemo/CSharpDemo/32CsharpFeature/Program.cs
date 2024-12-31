using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using _32CsharpFeature;



#region Nullable Types 
// int? i = null; //Nullable Syntax
//int? i = 10;
//Nullable<int> i = 10;
//if (i.HasValue)
//{
//    Console.WriteLine($"Value of i = {i}");
//}
//else
//{
//    Console.WriteLine("Value of i = null");
//}


// //if (i == null)
// //{
// //    Console.WriteLine("Value of i = null");
// //}


#endregion
#region Anonymous Methods 
//Normal Call To a Method
//Console.WriteLine("Enter a value ");
//int input = Convert.ToInt32(Console.ReadLine());
//bool result = Check(input);
//Console.WriteLine($" {input} is greater than 10 = {result}");

//Console.WriteLine("Enter a value ");
//int input = Convert.ToInt32(Console.ReadLine());
//MyDelegate del = new MyDelegate(Check);
//bool result = del(input);
//Console.WriteLine($" {input} is greater than 10 = {result}");


//Console.WriteLine("Enter a value ");
//int input = Convert.ToInt32(Console.ReadLine());

////This is method without Name - Anonymous Method
//MyDelegate del = delegate (int i)
//{
//    return i > 10;
//};
//bool result = del(input);

//Console.WriteLine($" {input} is greater than 10 = {result}");
#endregion
#region Lambda
Console.WriteLine("Enter value");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("hiiil");
MyDelegate del3 = i => i > 30;
bool result1 = del3(input);
Console.WriteLine($"{input} is greater than 30={result1}");
MyDelegate del = (i) =>
{
    return i > 20;
};
#endregion
#region Predicate



//Console.WriteLine("Enter a value");
//int input = Convert.ToInt32(Console.ReadLine());
//Predicate<int> pointer = i => i > 60;
//bool result = pointer(input);
//Console.WriteLine($"{input} is greater than 60 = {result} ");


#endregion

#region iterator
//Weeks weeks = new Weeks();
//foreach (string day in weeks)
//{
//    Console.WriteLine();
//}

#endregion

#region implicitType
//int i = 10;
//var j = "name";
//var k = 45.34;
//Console.WriteLine(i.GetType().ToString());
//Console.WriteLine(k.GetType().ToString());
//Emp emp = new Emp();
//var v = emp;
//Console.WriteLine(v.GetType().ToString());
//Console.WriteLine("Enter a number ");
//var choice = Convert.ToInt32(Console.ReadLine());
////var choice  = Console.ReadLine();
#endregion

#region ObjectInitializer

//Emp obj = new Emp() { Id =89,Ename="siya",Sal=670000,Dept="IT"};
//Console.WriteLine($"{obj.Id},{obj.Ename},{obj.Sal},{obj.Dept}");
//Emp obj2 = new Emp() { Id = 80, Ename = "riya", Sal = 90000 };
//Console.WriteLine($"{obj2.Id} ,{obj2.Ename},{obj2.Sal}");

#endregion

#region AutoProperties
//Emp emp = new Emp();
//emp.Dept = "cs";
//emp.Ename = "siya";
//Console.WriteLine($"{emp.Dept},{emp.Ename}");
#endregion

#region AnonymousType
//Emp emp = new Emp();
//var v = new Emp() { Id = 89, Ename = "siya", Sal = 670000, Dept = "IT" };
//Console.WriteLine(v.GetType().ToString());

#endregion

#region Extention Method
//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine(arr.Max());

//List<int> lstArr = arr.MyArrayToList();
//foreach (int x in lstArr)
//{
//    Console.WriteLine(x);
//}

////MyClass obj = new MyClass();
//string emailStr = "ab.com";
//bool result = emailStr.CheckForValidEmail(true);

//if (result)
//{
//    Console.WriteLine("Login successful");
//}
//else
//{
//    Console.WriteLine("Invalid Email");
//}

#endregion

namespace _32CsharpFeature
{
    public delegate bool MyDelegate(int x);
    public delegate bool Predicate <in T> (T x);


    #region iteratorclass
    //public class Weeks : IEnumerable
    //{
    //    private string[] Days = { "Monday", "Tueday", "Wedneay", "Thrusday,friday,Satrday,Sunday" };
    //    private object yeild;

    //    public IEnumerator GetEnumerator()
    //    {
    //        for (int i = 0; i < Days.Length; i++)
    //        {
    //            string day = Days[i];
    //            yield return day;
    //        }
    //    }
    //}
    #endregion


    #region simple calling
    //private static bool check(int i)
    //{
    //    return i > 20;
    //}
    #endregion
    #region Anonymousmethod
    //MyDelegate del = delegate (int i)
    //           {
    //               return i > 20;
    //           };
    //    bool result = del(input);
    //Console.WriteLine($"{input} is greater that 20 = {result}");
    #endregion
    #region Emp
    public class Emp
    {
        private int _id;
        private String _Ename;
        private double _sal;
        private string _dept;

        public string Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }


        public double Sal
        {
            get { return _sal; }
            set { _sal = value; }
        }



        public String Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
    #endregion

    #region MyClass
    public static class MyClass
    {
        public static List<int> MyArrayToList(this int[] para)
        {
            List<int> lst = new List<int>();
            foreach (int ele in para)
            {
                lst.Add(ele);
            }
            return lst;
        }
        public static bool CheckForValidEmail(this string str, bool nonsenseparameter)
        {
            Console.WriteLine(nonsenseparameter);
            return str.Contains("@") ? true : false;
            //if(str.Contains("@"))
            //{
            //    return true;
            //}
        }
    }
    #endregion
}




