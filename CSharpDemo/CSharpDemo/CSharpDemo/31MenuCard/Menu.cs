using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31MenuCard
{
    public class Menu : IVeg, INonVeg
    {

        List<MenuCard> INonVeg.displayNonVegMenu()
        {
            MenuCard NonVegMenu = new MenuCard("Butter Chicken", 300);
            MenuCard NonVegMenu1 = new MenuCard("Butter Mutton", 600);
            MenuCard NonvegMenu3 = new MenuCard("Mutton Handi", 700);
            List<MenuCard> nonVegMenu = new List<MenuCard>();
            nonVegMenu.Add(NonVegMenu);
            nonVegMenu.Add(NonVegMenu1);
            nonVegMenu.Add(NonvegMenu3);
            return nonVegMenu;

        }

        List<MenuCard> IVeg.displayVegMenu()
        {
            MenuCard VegMenu = new MenuCard("Butter Paneer", 300);
            MenuCard VegMenu1 = new MenuCard("Butter Kaju", 600);
            List<MenuCard> VegMenu11 = new List<MenuCard>();
            VegMenu11.Add(VegMenu);
            VegMenu11.Add(VegMenu1);
            return VegMenu11;
        }
    }
}
