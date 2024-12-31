using System.Collections;
using _31MenuCard;

namespace _25Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("What you want ");
                Console.WriteLine("1.Veg 2.Nonveg 3.Both 4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        VegMenu();
                        break;
                    case 2:
                        NonVegMenu();
                        break;
                    case 3:
                        VegMenu();
                        NonVegMenu();
                        break;
                }
            }
            while (choice != 4);
        }

        private static void NonVegMenu()
        {
            INonVeg nonVeg = new Menu();
            List<MenuCard> nonVegMenu = nonVeg.displayNonVegMenu();
            foreach (MenuCard item in nonVegMenu)
            {
                Console.WriteLine($"Dish Name : {item.ItemName}------> Price : {item.ItemPrice}");
            }
        }

        private static void VegMenu()
        {
            IVeg veg = new Menu();
            List<MenuCard> vegMenu = veg.displayVegMenu();
            foreach (MenuCard item in vegMenu)
            {
                Console.WriteLine($"Dish Name : {item.ItemName}------> Price : {item.ItemPrice}");
            }
        }

       
    }
}


