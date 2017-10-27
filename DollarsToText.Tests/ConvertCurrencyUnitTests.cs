using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText.Tests
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void ZeroNumber()
        {
            int currencyValue = 0;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "zero");
            Assert.AreEqual(testDollars.UnitString.Count, 1);
        }

        [TestMethod]
        public void SingleNumber()
        {
            int currencyValue = 1;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "one");
            Assert.AreEqual(testDollars.UnitString.Count, 1);
        }

        [TestMethod]
        public void SmallNumber()
        {
            int currencyValue = 19;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "nineteen");
            Assert.AreEqual(testDollars.UnitString.Count, 1);
        }

        [TestMethod]
        public void TensNumber()
        {
            int currencyValue = 35;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "thirty");
            Assert.AreEqual(testDollars.UnitString[1], "-");
            Assert.AreEqual(testDollars.UnitString[2], "five");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void TensNumberRounded()
        {
            int currencyValue = 61;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "sixty");
            Assert.AreEqual(testDollars.UnitString[1], "-");
            Assert.AreEqual(testDollars.UnitString[2], "one");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void HundredsNumber1()
        {
            int currencyValue = 506;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "five");
            Assert.AreEqual(testDollars.UnitString[1], " hundred ");
            Assert.AreEqual(testDollars.UnitString[2], "six");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void HundredsNumber2()
        {
            int currencyValue = 646;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "six");
            Assert.AreEqual(testDollars.UnitString[1], " hundred ");
            Assert.AreEqual(testDollars.UnitString[2], "forty");
            Assert.AreEqual(testDollars.UnitString[3], "-");
            Assert.AreEqual(testDollars.UnitString[4], "six");
            Assert.AreEqual(testDollars.UnitString.Count, 5);
        }

        [TestMethod]
        public void HundredsNumber3()
        {
            int currencyValue = 500;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "five");
            Assert.AreEqual(testDollars.UnitString[1], " hundred");
            Assert.AreEqual(testDollars.UnitString.Count, 2);
        }

        [TestMethod]
        public void ThousandsNumberRounded()
        {
            int currencyValue = 2000;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "two");
            Assert.AreEqual(testDollars.UnitString[1], " thousand");
            Assert.AreEqual(testDollars.UnitString.Count, 2);
        }

        [TestMethod]
        public void ThousandsNumber()
        {
            int currencyValue = 4798;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "four");
            Assert.AreEqual(testDollars.UnitString[1], " thousand ");
            Assert.AreEqual(testDollars.UnitString[2], "seven");
            Assert.AreEqual(testDollars.UnitString[3], " hundred ");
            Assert.AreEqual(testDollars.UnitString[4], "ninety");
            Assert.AreEqual(testDollars.UnitString[5], "-");
            Assert.AreEqual(testDollars.UnitString[6], "eight");
            Assert.AreEqual(testDollars.UnitString.Count, 7);
        }

        [TestMethod]
        public void TensThousandsNumberRounded()
        {
            int currencyValue = 80000;
            
            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "eighty");
            Assert.AreEqual(testDollars.UnitString[1], " thousand");
            Assert.AreEqual(testDollars.UnitString.Count, 2);
        }

        [TestMethod]
        public void TensThousandsNumber()
        {
            int currencyValue = 40500;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "forty");
            Assert.AreEqual(testDollars.UnitString[1], " thousand ");
            Assert.AreEqual(testDollars.UnitString[2], "five");
            Assert.AreEqual(testDollars.UnitString[3], " hundred");
            Assert.AreEqual(testDollars.UnitString.Count, 4);
        }

        public void HundredThousandsNumberRounded()
        {
            int currencyValue = 100000;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "one");
            Assert.AreEqual(testDollars.UnitString[1], "hundred");
            Assert.AreEqual(testDollars.UnitString[2], "thousand");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void HundredThousandsNumber()
        {
            int currencyValue = 239543;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "two");
            Assert.AreEqual(testDollars.UnitString[1], " hundred ");
            Assert.AreEqual(testDollars.UnitString[2], "thirty");
            Assert.AreEqual(testDollars.UnitString[3], "-");
            Assert.AreEqual(testDollars.UnitString[4], "nine");
            Assert.AreEqual(testDollars.UnitString[5], " thousand ");
            Assert.AreEqual(testDollars.UnitString[6], "five");
            Assert.AreEqual(testDollars.UnitString[7], " hundred ");
            Assert.AreEqual(testDollars.UnitString[8], "forty");
            Assert.AreEqual(testDollars.UnitString[9], "-");
            Assert.AreEqual(testDollars.UnitString[10], "three");
            Assert.AreEqual(testDollars.UnitString.Count, 11);
        }

        [TestMethod]
        public void MillionsNumberRounded()
        {
            int currencyValue = 2000000;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "two");
            Assert.AreEqual(testDollars.UnitString[1], " million");
            Assert.AreEqual(testDollars.UnitString.Count, 2);
        }

        [TestMethod]
        public void MillionsNumber()
        {
            int currencyValue = 5064501;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "five");
            Assert.AreEqual(testDollars.UnitString[1], " million ");
            Assert.AreEqual(testDollars.UnitString[2], "sixty");
            Assert.AreEqual(testDollars.UnitString[3], "-");
            Assert.AreEqual(testDollars.UnitString[4], "four");
            Assert.AreEqual(testDollars.UnitString[5], " thousand ");
            Assert.AreEqual(testDollars.UnitString[6], "five");
            Assert.AreEqual(testDollars.UnitString[7], " hundred ");
            Assert.AreEqual(testDollars.UnitString[8], "one");
            Assert.AreEqual(testDollars.UnitString.Count, 9);
        }

        [TestMethod]
        public void TensMillionsNumberRounded()
        {
            int currencyValue = 60000000;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "sixty");
            Assert.AreEqual(testDollars.UnitString[1], " million");
            Assert.AreEqual(testDollars.UnitString.Count, 2);
        }

        [TestMethod]
        public void TensMillionsNumber()
        {
            int currencyValue = 80000001;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "eighty");
            Assert.AreEqual(testDollars.UnitString[1], " million ");
            Assert.AreEqual(testDollars.UnitString[2], "one");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void HundredsMillionsNumberRounded()
        {
            int currencyValue = 300000000;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "three");
            Assert.AreEqual(testDollars.UnitString[1], " hundred");
            Assert.AreEqual(testDollars.UnitString[2], " million");
            Assert.AreEqual(testDollars.UnitString.Count, 3);
        }

        [TestMethod]
        public void HundredsMillionsNumber()
        {
            int currencyValue = 999999999;

            ConvertCurrencyEnglish testDollars = new ConvertCurrencyEnglish();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.UnitString[0], "nine");
            Assert.AreEqual(testDollars.UnitString[1], " hundred ");
            Assert.AreEqual(testDollars.UnitString[2], "ninety");
            Assert.AreEqual(testDollars.UnitString[3], "-");
            Assert.AreEqual(testDollars.UnitString[4], "nine");
            Assert.AreEqual(testDollars.UnitString[5], " million ");
            Assert.AreEqual(testDollars.UnitString[6], "nine");
            Assert.AreEqual(testDollars.UnitString[7], " hundred ");
            Assert.AreEqual(testDollars.UnitString[8], "ninety");
            Assert.AreEqual(testDollars.UnitString[9], "-");
            Assert.AreEqual(testDollars.UnitString[10], "nine");
            Assert.AreEqual(testDollars.UnitString[11], " thousand ");
            Assert.AreEqual(testDollars.UnitString[12], "nine");
            Assert.AreEqual(testDollars.UnitString[13], " hundred ");
            Assert.AreEqual(testDollars.UnitString[14], "ninety");
            Assert.AreEqual(testDollars.UnitString[15], "-");
            Assert.AreEqual(testDollars.UnitString[16], "nine");
            Assert.AreEqual(testDollars.UnitString.Count, 17);
        }
    }
}
