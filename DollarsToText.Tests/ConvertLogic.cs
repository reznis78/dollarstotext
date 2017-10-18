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

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "zero");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 2);
        }

        [TestMethod]
        public void SingleNumber()
        {
            int currencyValue = 1;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "one");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollar");
            Assert.AreEqual(testDollars.CurrencyString.Count, 2);
        }

        [TestMethod]
        public void SmallNumber()
        {
            int currencyValue = 19;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "nineteen");
            Assert.AreEqual(testDollars.CurrencyString[1], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 2);
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
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
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
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
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
            Assert.AreEqual(testDollars.CurrencyString.Count, 4);
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
            Assert.AreEqual(testDollars.CurrencyString.Count, 5);
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
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
        }

        [TestMethod]
        public void ThousandsNumberRounded()
        {
            int currencyValue = 2000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "two");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
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
            Assert.AreEqual(testDollars.CurrencyString[6], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 7);
        }

        [TestMethod]
        public void TensThousandsNumberRounded()
        {
            int currencyValue = 80000;
            
            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "eighty");
            Assert.AreEqual(testDollars.CurrencyString[1], " thousand");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
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
            Assert.AreEqual(testDollars.CurrencyString[4], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 5);
        }

        public void HundredThousandsNumberRounded()
        {
            int currencyValue = 100000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "one");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.CurrencyString[2], " thousand");
            Assert.AreEqual(testDollars.CurrencyString[3], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 4);
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
            Assert.AreEqual(testDollars.CurrencyString[9], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 9);
        }

        [TestMethod]
        public void MillionsNumberRounded()
        {
            int currencyValue = 2000000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "two");
            Assert.AreEqual(testDollars.CurrencyString[1], " million");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
        }

        [TestMethod]
        public void MillionsNumber()
        {
            int currencyValue = 5064501;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "five");
            Assert.AreEqual(testDollars.CurrencyString[1], " million ");
            Assert.AreEqual(testDollars.CurrencyString[2], "sixty");
            Assert.AreEqual(testDollars.CurrencyString[3], "four");
            Assert.AreEqual(testDollars.CurrencyString[4], " thousand ");
            Assert.AreEqual(testDollars.CurrencyString[5], "five");
            Assert.AreEqual(testDollars.CurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[7], "one");
            Assert.AreEqual(testDollars.CurrencyString[8], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 8);
        }

        [TestMethod]
        public void TensMillionsNumberRounded()
        {
            int currencyValue = 60000000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "sixty");
            Assert.AreEqual(testDollars.CurrencyString[1], " million");
            Assert.AreEqual(testDollars.CurrencyString[2], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 3);
        }

        [TestMethod]
        public void TensMillionsNumber()
        {
            int currencyValue = 80000001;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "eighty");
            Assert.AreEqual(testDollars.CurrencyString[1], " million ");
            Assert.AreEqual(testDollars.CurrencyString[2], "one");
            Assert.AreEqual(testDollars.CurrencyString[3], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 4);
        }

        [TestMethod]
        public void HundredsMillionsNumberRounded()
        {
            int currencyValue = 300000000;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "three");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.CurrencyString[2], " million");
            Assert.AreEqual(testDollars.CurrencyString[3], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 4);
        }

        [TestMethod]
        public void HundredsMillionsNumber()
        {
            int currencyValue = 999999999;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            Assert.AreEqual(testDollars.CurrencyString[0], "nine");
            Assert.AreEqual(testDollars.CurrencyString[1], " hundred");
            Assert.AreEqual(testDollars.CurrencyString[2], "ninety");
            Assert.AreEqual(testDollars.CurrencyString[3], "nine");
            Assert.AreEqual(testDollars.CurrencyString[4], " million ");
            Assert.AreEqual(testDollars.CurrencyString[5], "nine");
            Assert.AreEqual(testDollars.CurrencyString[6], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[7], "ninety");
            Assert.AreEqual(testDollars.CurrencyString[8], "nine");
            Assert.AreEqual(testDollars.CurrencyString[9], " thousand ");
            Assert.AreEqual(testDollars.CurrencyString[10], "nine");
            Assert.AreEqual(testDollars.CurrencyString[11], " hundred and ");
            Assert.AreEqual(testDollars.CurrencyString[12], "ninety");
            Assert.AreEqual(testDollars.CurrencyString[13], "nine");
            Assert.AreEqual(testDollars.CurrencyString[14], " dollars");
            Assert.AreEqual(testDollars.CurrencyString.Count, 14);
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
