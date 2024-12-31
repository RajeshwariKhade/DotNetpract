namespace _08Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Coventional Way Nested Switch
            //Console.WriteLine("1.SQLServer 2.MySQL 3.Oracle Server");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Database db = null;

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("1.Insert 2.Update 3.Delete");
            //        int ch = Convert.ToInt32(Console.ReadLine());
            //        db = new SQLServer();
            //        switch (ch)
            //        {
            //            case 1:
            //                db.insert();
            //                break;
            //            case 2:
            //                db.update();
            //                break;
            //            case 3:
            //                db.delete();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("1.Insert 2.Update 3.Delete");
            //        ch = Convert.ToInt32(Console.ReadLine());
            //        db = new MYSQLServer();
            //        switch (ch)
            //        {
            //            case 1:
            //                db.insert();
            //                break;
            //            case 2:
            //                db.update();
            //                break;
            //            case 3:
            //                db.delete();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine("1.Insert 2.Update 3.Delete");
            //        ch = Convert.ToInt32(Console.ReadLine());
            //        db = new OracleServer();
            //        switch (ch)
            //        {
            //            case 1:
            //                db.insert();
            //                break;
            //            case 2:
            //                db.update();
            //                break;
            //            case 3:
            //                db.delete();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            Console.WriteLine("1.SQLServer 2.MySQL 3.Oracle Server");
            int choice = Convert.ToInt32(Console.ReadLine());
            DatabaseFactory dbFactory = new DatabaseFactory();
            Database db = dbFactory.getDatabase(choice);

            Console.WriteLine("1.Insert 2.Update 3.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            db = new SQLServer();
            switch (ch)
            {
                case 1:
                    db.insert();
                    break;
                case 2:
                    db.update();
                    break;
                case 3:
                    db.delete();
                    break;
                default:
                    break;
            }
        }
        }

    public class DatabaseFactory
    {
        public Database getDatabase(int choice)
        {
            Database db = null;
            switch (choice)
            {
                case 1:
                    db = new SQLServer();
                    break;
                case 2:
                    db = new MYSQLServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default:
                    break;
            }
            return db;
        }
    }
    public interface Database
    {
        void insert();
        void update();
        void delete();
    }
    public class SQLServer : Database
    {
        public SQLServer()
        {
            Console.WriteLine("in sqlserver constructer ");

        }
        public void insert()
        {
            Console.WriteLine("in SQLServer Create method ");

        }
        public void update()
        {
            Console.WriteLine("in SQLServer update method");

        }
        public void delete()
        {
            Console.WriteLine("in SQLServer delete method");
        }
    }
    public class MYSQLServer : Database
    {
        public MYSQLServer()
        {
            Console.WriteLine("in MySQL constructer ");

        }
        public void insert()
        {
            Console.WriteLine("in MySQL Create method ");

        }
        public void update()
        {
            Console.WriteLine("in MySQL update method");

        }
        public void delete()
        {
            Console.WriteLine("in SQLServer delete method");
        }
    }
    public class OracleServer : Database
    {
        public OracleServer()
        {
            Console.WriteLine("in OracleServer constructer ");

        }
        public void insert()
        {
            Console.WriteLine("in OracleServer Create method ");

        }
        public void update()
        {
            Console.WriteLine("in OracleServer update method");

        }
        public void delete()
        {
            Console.WriteLine("in SQLServer delete method");
        }
    }




}
