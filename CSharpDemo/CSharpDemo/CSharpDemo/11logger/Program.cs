using System.Net.Http.Headers;

namespace _11logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("what you want 1.sqlsever 2.oracle 3.mysql");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("which opertaion you want to perform  1.insert 2.update 3.delete");
                int opchoice = Convert.ToInt32(Console.ReadLine());
                DatabaseFactory database = new DatabaseFactory();
                Database someDB = database.GetSomeDatabase(choice);
                switch (opchoice)
                {
                    case 1:
                        someDB.Insert();
                        break;
                    case 2:
                        someDB.Update();
                        break;
                    case 3:
                        someDB.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;

                }
                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }


            }
        }
    }
    public abstract class Database
    {
        public Logger _logger;

        public Database()
        {
            _logger = Logger.GetLogger();

        }

        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract String GetDatabaseName();
        String logmsg = null;
        public void Insert()
        {
            DoInsert();
            logmsg = String.Format("Insert happed in {0} Successfully ", GetDatabaseName());
            _logger.Log(logmsg);

        }
        public void Update()
        {
            DoUpdate();
            logmsg = String.Format("Update happed in {1} Successfully", GetDatabaseName());

        }
        public void Delete()
        {
            DoDelete();
            logmsg = String.Format("Delete happed in {2} Successfull", GetDatabaseName());
        }



    }
    public class DatabaseFactory 
    {
        public Database GetSomeDatabase(int choice)
        {
            Database someDatabase = null;
            switch (choice)
            {
                case 1:
                    someDatabase = new SQLServer();
                    break;
                case 2:
                    someDatabase = new MySQL();
                    break;
                
                default:
                    someDatabase = null;
                    break;
            }
            return someDatabase;
        }
    }
    public class SQLServer : Database
    {
        protected override String GetDatabaseName()
        {
            return "SQLServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Insert done in SQL Server Database");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Update done in SQL Server Database");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete done in SQL Server Database");
        }
    }


    public class MySQL : Database
    {
        protected override String GetDatabaseName()
        {
            return "Mysql";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Insert done in MYsql Database");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Update done in MYsql Database");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete done in MYsql Database");
        }
    }






    public class Logger
    {
        //object pooling
        private static Logger logger = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger object created for the first time...");
        }
        public static Logger GetLogger() //Factory Method
        {
            return logger;
        }
        public void Log(string message)
        {
            Console.WriteLine("--- Logged: " + message + " " + DateTime.Now.ToString());
        }
    }
}
