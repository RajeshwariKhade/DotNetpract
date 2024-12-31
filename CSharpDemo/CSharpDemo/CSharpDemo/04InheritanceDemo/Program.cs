namespace _04InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Parent p = new Parent(10, 20);
            //p.showNum();

            //Child c = new Child(10,20);
            //c.showNum();

            Parent p = new Child(10, 20);
            p.showNum();
        }
    }

    public  class Parent
    {
        private int num1;

        public Parent(int num1)
        {
            this.num1 = num1;
        }

        #region Virtual
        //public virtual void showNum()
        //{
        //    Console.WriteLine(num1);
        //}
        #endregion

        #region 
        //public sealed void showNum()
        //{
        //    Console.WriteLine(num1);
        //}
        #endregion

        public void showNum()
        {
            Console.WriteLine(num1);
        }

        public int add(int x, int y)
        {
            return x + y;
        }
    }

    public class Child : Parent
    {

        private int num2;

        public Child(int num1, int num2) : base(num1)
        {
            this.num2 = num2;
        }


        #region Method Shadowing
        //public new void showNum()
        //{
        //    base.showNum();
        //    Console.WriteLine(num2);
        //}
        #endregion

        #region Method Overriding
        //public override void showNum()
        //{
        //    base.showNum();
        //    Console.WriteLine(num2);
        //}
        #endregion

        public void showNum()
        {
            base.showNum();
            Console.WriteLine(num2);
        }

    }
}
