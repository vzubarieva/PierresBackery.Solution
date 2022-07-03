using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(
                "Welcome to our 'Pierre's Bakery'. We have fresh and very delicious bread and pastries! A single loaf costs $5 and cost of the pastry is $2. Check our special deals! ",
                Color.Yellow
            );
            Console.WriteLine("**************************************************************");
            Console.WriteLine(
                "A single loaf costs $5. Also we have special deal 'Buy 2, get 1 free' "
            );
            Console.WriteLine("Enter how many loaves of bread would you like today");
            string stringLoavesOfBread = Console.ReadLine();
            int loavesOfBread = int.Parse(stringLoavesOfBread);
            Bread newBread = new Bread(5);
            int breadCost = newBread.GetBreadCost(loavesOfBread);
            Console.WriteLine("It will be $" + breadCost, Color.Yellow);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine(
                "And we have delicious pastries! One pastry cost $2. Our special deal for pastries is 'Buy 1 for $2 or 3 for $5'"
            );
            Console.WriteLine("Enter how many pastries would you like today");
            string stringHowManyPastries = Console.ReadLine();
            int howManyPastries = int.Parse(stringHowManyPastries);
            Pastry newPastry = new Pastry(2);
            int pastryCost = newPastry.GetPastryCost(howManyPastries);
            Console.WriteLine("It will be $" + pastryCost, Color.Yellow);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int TotalCost;
            TotalCost = breadCost + pastryCost;
            Console.WriteLine(
                "The TOTAL COST of the order is $"
                    + TotalCost.ToString()
                    + ". Thank you for your order! ",
                Color.Blue
            );
        }
    }
}
