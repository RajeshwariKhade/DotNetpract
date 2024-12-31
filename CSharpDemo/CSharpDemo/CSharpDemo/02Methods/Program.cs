namespace _02Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 2 Numbers Input From User
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine()); 
            #endregion

            #region DoWhile, Switch & Methods Demo
            String choice = "yes";
            MathDemo mathDemo = new MathDemo();
            do
            {
                Console.WriteLine("1.Add 2.Subtract 3.Multiply 4.Division");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine(mathDemo.add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(mathDemo.subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(mathDemo.multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(mathDemo.division(num1, num2));
                        break;

                }
                Console.WriteLine("Do you want to continue");
                choice = Console.ReadLine();

            } while (choice.Equals("yes"));
            #endregion

            #region ForLoop Demo
            Demo demo = new Demo();
            demo.forLoopDemo();
            #endregion

            #region If Else Demo
            demo.ifElseDemo(num1, num2); 
            #endregion
        }
    }

    public class MathDemo
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y) 
        { 
            return x - y; 
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int division(int x, int y)
        {
            return x / y;
        }
    }

    public class Demo
    {
        public void forLoopDemo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ifElseDemo(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(num1 + "  " + num2 + "  are equal");
            }
            else if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num1 + " is less than " + num2);
            }
        }
    }
}
