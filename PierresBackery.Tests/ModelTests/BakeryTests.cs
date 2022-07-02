using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(0);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetBreadPrice_ReturnsBreadPrice_Int()
        {
            Bread newBread = new Bread(5);

            Assert.AreEqual(5, newBread.BreadPrice);
        }

        [TestMethod]
        public void GetBreadCost_ReturnsPriceOfLoaves_Int()
        {
            Bread newBread = new Bread(5);

            Assert.AreEqual(10, newBread.GetBreadCost(2));
        }

        [TestMethod]
        public void GetBreadCost_ReturnsPriceOfThreeLoaves_Int()
        {
            Bread newBread = new Bread(5);

            Assert.AreEqual(10, newBread.GetBreadCost(3));
        }

        [TestMethod]
        public void GetBreadCost_ReturnsPriceOfTenLoaves_Int()
        {
            Bread newBread = new Bread(5);

            Assert.AreEqual(35, newBread.GetBreadCost(10));
        }
    }

    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(0);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void GetPastryPrice_ReturnsPastryPrice_Int()
        {
            Pastry newPastry = new Pastry(2);

            Assert.AreEqual(2, newPastry.Price);
        }

        [TestMethod]
        public void GetPastryCost_ReturnsPastryOfPastry_Int()
        {
            Pastry newPastry = new Pastry(2);

            Assert.AreEqual(2, newPastry.GetPastryCost(1));
        }

        [TestMethod]
        public void GetPastryCost_ReturnsPastryOfFivePastry_Int()
        {
            Pastry newPastry = new Pastry(2);

            Assert.AreEqual(9, newPastry.GetPastryCost(5));
        }
    }
}
