using System.Security.Cryptography.X509Certificates;

namespace _18DelegateDemo
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnualFunction annualFunction = new AnnualFunction();

            MyDelegate del = new MyDelegate(annualFunction.function1);
            del += annualFunction.function2;
            del += annualFunction.function3;
            del += annualFunction.function4;

            Console.WriteLine("Celebrity Arrived?");
            bool status = Convert.ToBoolean(Console.ReadLine());

            if (!status)
            {
                del -= annualFunction.function3;
            }

            del();

        }
    }

    public class AnnualFunction
    {
        public void function1()
        {
            Console.WriteLine("Welcome Speech");
        }

        public void function2()
        {
            Console.WriteLine("Guest Speech");
        }

        public void function3()
        {
            Console.WriteLine("Invite For Party");
        }

        public void function4()
        {
            Console.WriteLine("Pack Up");
        }
    }
}
