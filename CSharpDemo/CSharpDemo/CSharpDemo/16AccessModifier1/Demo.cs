namespace _16AccessModifier1
{
    public class Demo
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        protected int Sub(int x, int y)
        {
            return x - y;
        }

        private int Mult(int x, int y)
        {
            return x * y;
        }

        internal int Div(int x, int y)
        {
            return x / y;
        }

        protected internal int Square(int x)
        {
            return x * x;
        }
    }
}
