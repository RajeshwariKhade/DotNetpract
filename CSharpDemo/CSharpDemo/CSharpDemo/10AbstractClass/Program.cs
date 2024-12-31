namespace _10AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.PDF 2.Docx");
            int choice = Convert.ToInt32(Console.ReadLine());
            Report report = null;
            switch (choice)
            {
                case 1:
                    report = new PDF();
                    report.GenerateReport();
                    break;
                case 2:
                    report = new Docx();
                    report.GenerateReport();
                    break;
                default:
                    break;
            }
        }
    }

    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public void GenerateReport()
        {
            Parse();
            Validate();
            Save();
        }
    }

    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsing");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    public class Docx : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsing");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated");
        }
    }


}
