namespace _15GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "xyz";
            int x = 10;
            int y = 20;
            int sum;

            CMath<int> cMath = new CMath<int>();
            Console.WriteLine("Before Swapping s1 : {0}, s2 : {1}",s1,s2);
            cMath.Swap<string>(ref s1, ref s2);
            Console.WriteLine("After Swapping s1 : {0}, s2 : {1}", s1, s2);

            cMath.Calculate(x, y, out sum);
            Console.WriteLine(sum);

            var Customer = Display();
            Console.WriteLine(Customer);
            Console.WriteLine(Customer.name);
        }

        #region Tuples
        public static (int id, string name, string address) Display()
        {
            int id = 1;
            string name = "abcd";
            string address = "Pune";

            return (id, name, address);
        } 
        #endregion
    }

    //Generic Class
    public class CMath<P>
    {
        #region Generic Method
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Dynamic
        public void Calculate(P x, P y, out P sum)
        {
            dynamic p1 = x;
            dynamic p2 = y;
            sum = p1 + p2;
        } 
        #endregion
    }
}
