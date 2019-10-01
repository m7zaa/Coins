using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Coins.Models;
using System;

namespace Coins.Tests
{
    [TestClass]
    public class CoinsTest
    {
        // [TestMethod]
        // public void ConvertToQuarters_NumberDivisibleby25_4()
        // {
        //     CoinsClass test = new CoinsClass();
        //     test.ConvertToQuarters(1);
        //     Assert.AreEqual(4, test.Quarters);
        // }
        // [TestMethod]
        // public void ConvertToDimes_NumberDivisibleby10_10()
        // {
        //     CoinsClass test = new CoinsClass();
        //     test.ConvertToDimes(1);
        //     Assert.AreEqual(10, test.Dimes);
        // }
        // [TestMethod]
        // public void ConvertToNickels_NumberDivisibleby5_20()
        // {
        //     CoinsClass test = new CoinsClass();
        //     test.ConvertToNickels(1);
        //     Assert.AreEqual(20, test.Nickels);
        // }
        // [TestMethod]
        // public void ConvertToNickels_NumberDivisibleby1_100()
        // {
        //     CoinsClass test = new CoinsClass();
        //     test.ConvertToNickels(4);
        //     Assert.AreEqual(4, test.Pennies);
        // }
        // [TestMethod]
        // public void ConvertToQuarters_CorrectDimeChange_1()
        // {
        //     CoinsClass test = new CoinsClass();
        //     test.ConvertToQuarters(.87);
        //     Assert.AreEqual(1, test.Dimes);
        // }
        [TestMethod]
        public void ConvertToQuarters_CorrectPennyChange_2()
        {
            CoinsClass test = new CoinsClass();
            test.ConvertToQuarters(.87);
            Assert.AreEqual(2, test.Pennies);
        }
        [TestMethod]
        public void ConvertToQuarters_CorrectNickelChange_1()
        {
            CoinsClass test = new CoinsClass();
            test.ConvertToQuarters(.80);
            Assert.AreEqual(1, test.Nickels);
        }



    }
}
