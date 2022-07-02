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
}
