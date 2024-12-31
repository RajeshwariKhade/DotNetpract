using System.Net.Http.Headers;

namespace _05Inheritancedemo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            Base b = new Base();

            Console.WriteLine(b.add(10, 20));
        }
    }
    public class  Base
    {
        public Base()
        {
            Console.WriteLine("In defult construter parent");
        }
        //public int add(int x,int y)
        //{
        //    return x + y;
        //}
        public int  add(int x, int y)
        {
            return x + y;
        }

    }
    public class derived : Base
    {
        public derived()
        {
            Console.WriteLine("In defult construter derived");
        }
        public int sub(int x,int y)
        {
            return x - y;
        }
        //public int add(int x, int y)
        //{
        //    return (x + y) * 10;
        //}
        //public override int add(int x, int y)
        //{
        //    return (x + y) * 10;
        //}
        //public new int add(int x, int y)
        //{
        //    return (x + y) * 10;
        //}
        public int add(int x, int y)
        {
            return (x + y) * 10;
        }
    }
}
