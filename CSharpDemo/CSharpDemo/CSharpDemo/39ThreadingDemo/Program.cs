namespace _39ThreadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multi Threading
            //Thread t1 = new Thread(new ThreadStart(PrintTable));
            //t1.Start();
            //Thread t2 = new Thread(new ThreadStart(PrintTable));
            //t2.Start(); 
            #endregion

            #region Explicit Parallel Programming - Multiple Tasks
            //Task t1 = new Task(new Action(PrintTable));
            //t1.Start();
            //Task t2 = new Task(new Action(PrintTable));
            //t2.Start();
            #endregion

            #region Parallel ForEach - Implicit
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(arr, (number) =>
            {
                Console.WriteLine($"{number}, Task ID : {Task.CurrentId}, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            });
            #endregion

            Console.WriteLine("------------------------------------------------------------------------------");

            #region MaxDegreeOfParallelism
            var options = new ParallelOptions { MaxDegreeOfParallelism = 2};
            Parallel.ForEach(arr, options, (number) =>
            {
                Console.WriteLine($"{number}, Task ID : {Task.CurrentId}, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            });
            #endregion

            Console.WriteLine("------------------------------------------------------------------------------------------");

            #region Exception Handling with Parallel ForEach
            Parallel.ForEach(arr, (number) =>
            {
                Console.WriteLine(number);
                if(number == 3)
                {
                    throw new Exception("Exception");
                }
            });
            #endregion
        }

        public static void PrintTable()
        {
            for (int i = 1; i <= 100; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine(i + " * " + j +" = "+ result);
                }
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
