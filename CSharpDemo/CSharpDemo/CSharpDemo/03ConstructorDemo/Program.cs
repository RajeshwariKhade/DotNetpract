namespace _03ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorDemo constructorDemo = new ConstructorDemo(10, 20);
            Console.WriteLine(constructorDemo.addition());
            Console.WriteLine(constructorDemo.square());
        }
    }

    public class ConstructorDemo
    {
        int num1;
        int num2;

        #region Constructor Overloading
        public ConstructorDemo(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public ConstructorDemo(int num1)
        {
            this.num1 = num1;
        } 
        #endregion

        public int addition()
        {
            return num1 + num2;
        }

        public int square()
        {
            return num1 * num1;
        }
    }
}
