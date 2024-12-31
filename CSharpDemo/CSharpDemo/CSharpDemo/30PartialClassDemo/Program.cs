using _29C_FeaturePartialClass;

namespace _30PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            Console.WriteLine(cMath.add(10,20));
            Console.WriteLine(cMath.sub(10, 20));
        }
    }
}
