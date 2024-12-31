using System.Collections;

namespace _13CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList without Generics
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Test";
            customer.Address = "Pune";

            ArrayList alst = new ArrayList();
            alst.Add(1);
            alst.Add("ABC");
            alst.Add(1.11);
            alst.Add(customer);

            foreach (var item in alst)
            {
                if (item is int)
                {
                    Console.WriteLine(Convert.ToInt32(item));
                }
                if (item is string)
                {
                    Console.WriteLine(Convert.ToString(item));
                }
                if (item is double)
                {
                    Console.WriteLine(Convert.ToDouble(item));
                }
                if (item is Customer)
                {
                    Customer cust = item as Customer;
                    string result = $"ID : {cust.Id}, Name : {cust.Name}, Address : {cust.Address}";
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region List with Generics
            //List<Customer> list = new List<Customer>();
            //Customer customer1 = new Customer();
            //customer1.Id = 1;
            //customer1.Name = "ABC";
            //customer1.Address = "Pune";

            //Customer customer2 = new Customer();
            //customer2.Id = 2;
            //customer2.Name = "PQR";
            //customer2.Address = "Mumbai";

            //Customer customer3 = new Customer();
            //customer3.Id = 1;
            //customer3.Name = "ABC";
            //customer3.Address = "Pune";

            //list.Add(customer1);
            //list.Add(customer2);
            //list.Add(customer3);

            //foreach (Customer cust in list)
            //{
            //    string result = $"ID : {cust.Id}, Name : {cust.Name}, Address : {cust.Address}";
            //    Console.WriteLine(result);
            //} 
            #endregion


        }
    }

    public class Customer
    {
        private int _CId;
        private string _CName;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string Name
        {
            get { return _CName; }
            set { _CName = value; }
        }


        public int Id
        {
            get { return _CId; }
            set { _CId = value; }
        }

    }
}
