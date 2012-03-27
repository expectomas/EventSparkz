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

        public Budget(int i_itemId, double i_itemPrice, string i_itemName)
        {
            itemId = i_itemId;
            itemPrice = i_itemPrice;
            itemName = i_itemName;
        }

        public void requestBudgetDetails(ref int o_itemId, ref double o_itemPrice, ref string o_itemName)
        {
            o_itemId = itemId;
            o_itemPrice = itemPrice;
            o_itemName = itemName;
        }
    }
}
