using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Budget
    {
        private int itemId;
        private double itemPrice;
        private string itemName;

        Budget(int i_itemId, double i_itemPrice, string i_itemName)
        {
            itemId = i_itemId;
            itemPrice = i_itemPrice;
            itemName = i_itemName;
        }
    }
}
