namespace _14PassByAndOutDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();

            int x = 10;
            int y = 20;

            #region Pass By Value
            //Console.WriteLine("Before Swapping x = {0}, y = {1}", x, y);
            //cMath.Swap(x, y);
            //Console.WriteLine("After Swapping x = {0}, y = {1}", x, y); 
            #endregion

            #region Pass By Reference
            //Console.WriteLine("Before Swapping x = {0}, y = {1}", x, y);
            //cMath.Swap(ref x, ref y);
            //Console.WriteLine("After Swapping x = {0}, y = {1}", x, y); 
            #endregion

            #region out keyword
            int sum, product;
            cMath.Calculate(x, y, out sum, out product);
            Console.WriteLine(sum);
            Console.WriteLine(product); 
            #endregion

        }
    }

    public class CMath
    {
        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Calculate(int x,int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }
    }
}
