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
    }
}
