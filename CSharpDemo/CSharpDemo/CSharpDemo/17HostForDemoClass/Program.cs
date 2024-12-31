using _16AccessModifier1;

namespace _17HostForDemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();

            Console.WriteLine(demo.Add(10, 20)); 

            Demo1 demo1 = new Demo1();

            demo1.getData();
        }
    }

    public class Demo1 : Demo
    {
        public void getData()
        {
            int square = base.Square(5);
            Console.WriteLine(square);
            int sub = base.Sub(20, 10);
            Console.WriteLine(sub);
        }
    }
}
