using _37EntityFramework.DAL;
using _37EntityFramework.Model;

namespace _37EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoDBContext dbContext = new DemoDBContext();
            #region Employees Context With Migration
            while (true)
            {
                Console.WriteLine("Enter operation choice 1. Select, 2. Insert, 3.Update, 4.Delete, 5. Find By ID Stored Procedure");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        var allEmployees = dbContext.employees.ToList();
                        foreach (var emp in allEmployees)
                        {
                            Console.WriteLine($"Id: {emp.EId}, Name: {emp.EName}, Address: {emp.EAddress}");
                        }
                        break;
                    case 2:
                        Employee empRecordToBeInserted = new Employee();
                        Console.WriteLine("Enter Name:");
                        empRecordToBeInserted.EName = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeInserted.EAddress = Console.ReadLine();

                        dbContext.employees.Add(empRecordToBeInserted);
                        dbContext.employees.Add(empRecordToBeInserted);
                        dbContext.SaveChanges();
                        break;
                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Employee empRecordToBeUpdated = dbContext.employees.Find(id);

                        Console.WriteLine("Enter Name:");
                        empRecordToBeUpdated.EName = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeUpdated.EAddress = Console.ReadLine();

                        dbContext.SaveChanges();
                        break;
                    case 4:
                        Console.WriteLine("Enter Id");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Employee empToBeDeleted = dbContext.employees.Find(id1);
                        dbContext.employees.Remove(empToBeDeleted);
                        dbContext.SaveChanges();
                        break;
                    case 5:
                        Console.WriteLine("Enter Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Employee emp1 = dbContext.GetEmpById(id2);
                        Console.WriteLine($"Id: {emp1.EId}, Name: {emp1.EName}, Address: {emp1.EAddress}");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string? ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
            #endregion

            #region Students Context Without Migration
            //while (true)
            //{
            //    Console.WriteLine("Enter operation choice 1. Select, 2. Insert, 3.Update, 4.Delete");
            //    int opChoice = Convert.ToInt32(Console.ReadLine());
            //    switch (opChoice)
            //    {
            //        case 1:
            //            var allStudents = dbContext.students.ToList();
            //            foreach (var stud in allStudents)
            //            {
            //                Console.WriteLine($"Id: {stud.Id}, Name: {stud.Name}, Address: {stud.Address}");
            //            }
            //            break;
            //        case 2:
            //            Student empRecordToBeInserted = new Student();
            //            Console.WriteLine("Enter Name:");
            //            empRecordToBeInserted.Name = Console.ReadLine();
            //            Console.WriteLine("Enter Address:");
            //            empRecordToBeInserted.Address = Console.ReadLine();

            //            dbContext.students.Add(empRecordToBeInserted);
            //            dbContext.students.Add(empRecordToBeInserted);
            //            dbContext.SaveChanges();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter Id");
            //            int id = Convert.ToInt32(Console.ReadLine());

            //            Student empRecordToBeUpdated = dbContext.students.Find(id);

            //            Console.WriteLine("Enter Name:");
            //            empRecordToBeUpdated.Name = Console.ReadLine();
            //            Console.WriteLine("Enter Address:");
            //            empRecordToBeUpdated.Address = Console.ReadLine();

            //            dbContext.SaveChanges();
            //            break;
            //        case 4:
            //            Console.WriteLine("Enter Id");
            //            int id1 = Convert.ToInt32(Console.ReadLine());
            //            Student empToBeDeleted = dbContext.students.Find(id1);
            //            dbContext.students.Remove(empToBeDeleted);
            //            dbContext.SaveChanges();
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice..");
            //            break;
            //    }

            //    Console.WriteLine("Do you want to continue? y/n");
            //    string? ynChoice = Console.ReadLine();
            //    if (ynChoice == "n")
            //    {
            //        break;
            //    }
            //} 
            #endregion

        }
    }
}
