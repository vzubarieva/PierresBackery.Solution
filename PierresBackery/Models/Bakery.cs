using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadPrice { get; }

        public Bread(int breadPrice)
        {
            BreadPrice = breadPrice;
        }

        public int GetBreadCost(int loaf)
        {
            double loafAdjustment = loaf / 3;
            return BreadPrice * (loaf - (int)Math.Floor(loafAdjustment));
        }
    }

    public class Pastry
    {
        public int Price { get; }

        public Pastry(int price)
        {
            Price = price;
        }

        public int GetPastryCost(int pastry)
        {
            return Price * pastry - (((int)Math.Floor((double)pastry / 3) * Price) / 2);
        }
    }
}
