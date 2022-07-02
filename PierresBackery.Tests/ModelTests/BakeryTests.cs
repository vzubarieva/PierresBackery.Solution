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


    }
}
