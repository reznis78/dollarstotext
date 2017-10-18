﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText.Tests
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void ZeroNumber()
        {
            int currencyValue = 0;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "zero");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollars");
        }

        [TestMethod]
        public void SingleNumber()
        {
            int currencyValue = 1;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "one");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollar");
        }

        [TestMethod]
        public void SmallNumber()
        {
            int currencyValue = 19;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "nineteen");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollars");
        }

        [TestMethod]
        public void TensNumber()
        {
            int currencyValue = 35;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "thirty");
            Assert.AreEqual(testDollars.CurrencyString[1], "five");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
        }

        [TestMethod]
        public void TensNumberRounded()
        {
            int currencyValue = 61;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "sixty");
            Assert.AreEqual(testDollars.CurrencyString[1], "one");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
        }

        [TestMethod]
        public void HundredsNumber1()
        {
            int currencyValue = 506;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "five");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[2], "six");
            Assert.AreEqual(testDollars.CurrencyString[3], " dollars");
        }

        [TestMethod]
        public void HundredsNumber2()
        {
            int currencyValue = 646;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "six");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[2], "forty");
            Assert.AreEqual(testDollars.CurrencyString[3], "six");
            Assert.AreEqual(testDollars.CurrencyString[4], " dollars");
        }

        [TestMethod]
        public void HundredsNumber3()
        {
            int currencyValue = 500;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "five");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
        }

        [TestMethod]
        public void ThousandsNumberRounded()
        {
            int currencyValue = 2000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "two");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand");
        }

        [TestMethod]
        public void ThousandsNumber()
        {
            int currencyValue = 4798;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "four");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand ");
            Assert.AreEqual(testDollars.CurrencyString[2], "seven");
            Assert.AreEqual(testDollars.CurrencyString[3], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[4], "ninety");
            Assert.AreEqual(testDollars.CurrencyString[5], "eight");
        }

        [TestMethod]
        public void TensThousandsNumberRounded()
        {
            int currencyValue = 80000;
            
            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "eighty");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand");
        }

        [TestMethod]
        public void TensThousandsNumber()
        {
            int currencyValue = 40500;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "forty");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand ");
            Assert.AreEqual(testDollars.CurrencyString[2], "five");
            Assert.AreEqual(testDollars.CurrencyString[3], " hundred");
        }

        public void HundredThousandsNumberRounded()
        {
            int currencyValue = 100000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "one");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.CurrencyString[2], " thousand");
        }

        [TestMethod]
        public void HundredThousandsNumber()
        {
            int currencyValue = 239543;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "two");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[2], "thirty");
            Assert.AreEqual(testDollars.CurrencyString[3], "nine");
            Assert.AreEqual(testDollars.CurrencyString[4], " thousand ");
            Assert.AreEqual(testDollars.CurrencyString[5], "five");
            Assert.AreEqual(testDollars.CurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[7], "forty");
            Assert.AreEqual(testDollars.CurrencyString[8], "three");
        }

        [TestMethod]
        public void SplitString()
        {
            string testInput = "9874,03";

            string[] splitCurrency = testInput.Split(new string[] { "," }, StringSplitOptions.None);

            Assert.AreEqual(splitCurrency[0], "9874");
            Assert.AreEqual(splitCurrency[1], "03");
        }

        [TestMethod]
        public void ConvertStringToInt()
        {
            string[] splitCurrency = { "9874", "03" };

            int dollarValue; 
            int.TryParse(splitCurrency[0], out dollarValue);

            int centsValue;
            int.TryParse(splitCurrency[1], out centsValue);

            Assert.AreEqual(dollarValue, 9874);
            Assert.AreEqual(centsValue, 03); 
        }


    }
}
