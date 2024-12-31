using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31MenuCard
{
    public class MenuCard
    {
        private string _ItemName;
        private int _ItemPrice;

        public MenuCard(string v1, int v2)
        {
            ItemName = v1;
            ItemPrice = v2;
        }

        public int ItemPrice
        {
            get { return _ItemPrice; }
            set { _ItemPrice = value; }
        }


        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }


    }
}
