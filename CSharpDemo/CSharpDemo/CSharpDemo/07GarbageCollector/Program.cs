namespace _07GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Garbage Collector Generations Gen0, Gen1, Gen2
            Console.WriteLine("The number of generations are: " + GC.MaxGeneration); 
            #endregion

            #region Find Generation Number of Object
            Demo d = new Demo();
            d.add(10, 20);
            Console.WriteLine(
            "The generation number of object obj is: "
            + GC.GetGeneration(d));
            #endregion

            #region Total Memory Allocated
            Console.WriteLine("Total Memory:"
                             + GC.GetTotalMemory(false)); 
            #endregion

        }
    }

    public class Demo
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + " " + y);
        }
    }
}
