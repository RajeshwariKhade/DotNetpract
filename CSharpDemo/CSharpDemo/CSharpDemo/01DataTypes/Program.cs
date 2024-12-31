namespace _01DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = num1 + num2;
            Console.WriteLine(total);
        }
    }
}
