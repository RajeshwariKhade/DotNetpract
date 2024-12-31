namespace _06ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int y = Convert.ToInt32(Console.ReadLine());

            ExceptionDemo(x, y);
        }

        public static void ExceptionDemo(int x, int y)
        {
            try
            {
                int result = x / y;
                if (x > 10)
                {
                    throw new Exception(x + " is greater than 10");
                }
                else if (y > 10)
                {
                    throw new Exception(y + " is greater than 10");
                }
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
