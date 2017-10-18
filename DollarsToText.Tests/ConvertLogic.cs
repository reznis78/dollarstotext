using System;
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

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "zero");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 1);
        }

        [TestMethod]
        public void SingleNumber()
        {
            int currencyValue = 1;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "one");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 1);
        }

        [TestMethod]
        public void SmallNumber()
        {
            int currencyValue = 19;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "nineteen");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 1);
        }

        [TestMethod]
        public void TensNumber()
        {
            int currencyValue = 35;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "thirty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void TensNumberRounded()
        {
            int currencyValue = 61;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "sixty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], "one");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void HundredsNumber1()
        {
            int currencyValue = 506;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "six");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 3);
        }

        [TestMethod]
        public void HundredsNumber2()
        {
            int currencyValue = 646;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "six");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "forty");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], "six");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 4);
        }

        [TestMethod]
        public void HundredsNumber3()
        {
            int currencyValue = 500;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void ThousandsNumberRounded()
        {
            int currencyValue = 2000;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "two");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " thousand");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void ThousandsNumber()
        {
            int currencyValue = 4798;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "four");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " thousand ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "seven");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[4], "ninety");
            Assert.AreEqual(testDollars.BaseCurrencyString[5], "eight");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 6);
        }

        [TestMethod]
        public void TensThousandsNumberRounded()
        {
            int currencyValue = 80000;
            
            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "eighty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " thousand");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void TensThousandsNumber()
        {
            int currencyValue = 40500;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "forty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " thousand ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], " hundred");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 4);
        }

        public void HundredThousandsNumberRounded()
        {
            int currencyValue = 100000;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "one");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], " thousand");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 3);
        }

        [TestMethod]
        public void HundredThousandsNumber()
        {
            int currencyValue = 239543;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "two");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "thirty");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[4], " thousand ");
            Assert.AreEqual(testDollars.BaseCurrencyString[5], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[7], "forty");
            Assert.AreEqual(testDollars.BaseCurrencyString[8], "three");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 9);
        }

        [TestMethod]
        public void MillionsNumberRounded()
        {
            int currencyValue = 2000000;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "two");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " million");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void MillionsNumber()
        {
            int currencyValue = 5064501;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " million ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "sixty");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], "four");
            Assert.AreEqual(testDollars.BaseCurrencyString[4], " thousand ");
            Assert.AreEqual(testDollars.BaseCurrencyString[5], "five");
            Assert.AreEqual(testDollars.BaseCurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[7], "one");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 8);
        }

        [TestMethod]
        public void TensMillionsNumberRounded()
        {
            int currencyValue = 60000000;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "sixty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " million");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 2);
        }

        [TestMethod]
        public void TensMillionsNumber()
        {
            int currencyValue = 80000001;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "eighty");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " million ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "one");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 3);
        }

        [TestMethod]
        public void HundredsMillionsNumberRounded()
        {
            int currencyValue = 300000000;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "three");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], " million");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 3);
        }

        [TestMethod]
        public void HundredsMillionsNumber()
        {
            int currencyValue = 999999999;

            ConvertBaseCurrency testDollars = new ConvertBaseCurrency();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.BaseCurrencyString[0], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[1], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[2], "ninety");
            Assert.AreEqual(testDollars.BaseCurrencyString[3], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[4], " million ");
            Assert.AreEqual(testDollars.BaseCurrencyString[5], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[7], "ninety");
            Assert.AreEqual(testDollars.BaseCurrencyString[8], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[9], " thousand ");
            Assert.AreEqual(testDollars.BaseCurrencyString[10], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString[11], " hundred and ");
            Assert.AreEqual(testDollars.BaseCurrencyString[12], "ninety");
            Assert.AreEqual(testDollars.BaseCurrencyString[13], "nine");
            Assert.AreEqual(testDollars.BaseCurrencyString.Count, 14);
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
