using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Coins.Models;
using System;

namespace Coins.Tests
{
    [TestClass]
    public class CoinsTest
    {
        [TestMethod]
        public void ConvertToQuarters_NumberDivisibleby25_4()
        {
            CoinsClass testQuarters = new CoinsClass();
            testQuarters.ConvertToQuarters(1);
            Assert.AreEqual(4, testQuarters.Quarters);
        }
    }
}