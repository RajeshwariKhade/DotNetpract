namespace _12Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Arrays

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region Accessing Elements with Range
            //int[] subArr = arr[..2];
            //foreach (int i in subArr)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Accessing Elements with Indices
            Console.WriteLine(arr[^1]);
            Console.WriteLine(arr[^2]);
            #endregion

            #region Using string.Join
            string str = string.Join(",", arr);
            Console.WriteLine(str); 
            #endregion

            #region  object Arrays

            object[] arr2 = new object[3];
            arr2[0] = "c#";
            arr2[1] = 2;
            arr2[2] = 23.2;
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
                
            }


            #endregion





        }
    }
    
}
