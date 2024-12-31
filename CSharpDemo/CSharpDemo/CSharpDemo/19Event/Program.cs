namespace _19Event
{
    public delegate void Resulthandler(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
           
            Resulthandler resultpass = new Resulthandler(student.Succefull);
            student.Pass += resultpass;
            Resulthandler resultfaill = new Resulthandler(student.unsuccesfull);
            student.Faill += resultfaill;
            Console.WriteLine("Enter student mark");
            student.Mark = Convert.ToInt32(Console.ReadLine());


        }
    }
    public class Student
    {
        public event Resulthandler Pass;
        public event Resulthandler Faill;
      

        private int _Mark;

        public int Mark
        {
            get { return _Mark; }
            set {
                _Mark = value;
                if (_Mark > 40)
                {
                    Pass(_Mark);
                }
                else
                {
                    Faill(_Mark);
                }
                
               
            }
        }
        public void Succefull(int mark)
        {
            Console.WriteLine("Student pass");
        }
        public void unsuccesfull(int mark)
        {
            Console.WriteLine("Student fail");
        }
    }

}
