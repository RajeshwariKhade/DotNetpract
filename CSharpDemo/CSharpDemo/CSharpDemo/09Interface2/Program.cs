namespace _09Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Silver Customer");
            Console.WriteLine("2.Gold Customer");
            Console.WriteLine("3.Platinum Customer");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ISilverCustomer customer = new Customer();
                    Console.WriteLine("1.Credit Amount 2.Debit Amount 3.Update Profile");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            customer.creditAmount(100);
                            break;
                        case 2:
                            customer.debitAmount(100);
                            break;
                        case 3:
                            customer.updateProfile();
                            break;
                        default:
                            break;
                    }

                    break;
                case 2:
                    IGoldCustomer customer1 = new Customer();
                    Console.WriteLine("1.Credit Amount 2.Debit Amount 3.Update Profile 4.NEFT");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            customer1.creditAmount(100);
                            break;
                        case 2:
                            customer1.debitAmount(100);
                            break;
                        case 3:
                            customer1.updateProfile();
                            break;
                        case 4:
                            customer1.NEFT(100);
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    IPlatinumCustomer customer2 = new Customer();
                    Console.WriteLine("1.Credit Amount 2.Debit Amount 3.Update Profile 4.NEFT 5.UPI");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            customer2.creditAmount(100);
                            break;
                        case 2:
                            customer2.debitAmount(100);
                            break;
                        case 3:
                            customer2.updateProfile();
                            break;
                        case 4:
                            customer2.NEFT(100);
                            break;
                        case 5:
                            customer2.UPI(100);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    public interface ISilverCustomer
    {
        void creditAmount(int amount);
        void debitAmount(int amount);
       
        void updateProfile();
    }
    public interface IGoldCustomer : ISilverCustomer
    {
        void NEFT(int amount);
    }

    public interface IPlatinumCustomer : ISilverCustomer, IGoldCustomer
    {
        void UPI(int amount);
    }
    public class Customer : IGoldCustomer, ISilverCustomer, IPlatinumCustomer
    {
        void ISilverCustomer.creditAmount(int amount)
        {
            Console.WriteLine(amount + " credited");
        }

        void ISilverCustomer.debitAmount(int amount)
        {
            Console.WriteLine(amount + " debited");
        }

        void IGoldCustomer.NEFT(int amount)
        {
            Console.WriteLine(amount + " NEFT Done");
        }

        void ISilverCustomer.updateProfile()
        {
            Console.WriteLine("Profile Updated");
        }

        void IPlatinumCustomer.UPI(int amount)
        {
            Console.WriteLine(amount + " UPI Done");
        }


    }
}
