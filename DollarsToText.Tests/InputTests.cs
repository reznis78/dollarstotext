using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText.Tests
{
    [TestClass]
    public class InputTests
    {
        //Test to trim currency input

        [TestMethod]
        public void CurrencyInputTrim()
        {
            string input = ("  1234,56  ");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.TrimUserInput(input);

            Assert.AreEqual(testInput.TrimmedUserInput, "1234,56");
        }

        //Tests to split currency

        [TestMethod]
        public void CurrencyInputNull()
        {
            string input = ("");

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0],"");
        }

        [TestMethod]
        public void CurrencyInputSplit()
        {
            string input = ("123,45");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "123");
            Assert.AreEqual(testInput.SplitCurrency[1], "45");
        }

        [TestMethod]
        public void CurrencyInputSplitNull()
        {
            string input = (",");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "");
            Assert.AreEqual(testInput.SplitCurrency[1], "");
        }

        [TestMethod]
        public void CurrencyInputSplitBase()
        {
            string input = ("50");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "50");
            Assert.AreEqual(testInput.SplitCurrency.Count, 1);
        }

        [TestMethod]
        public void CurrencyInputSplitSubUnitBaseEmpty()
        {
            string input = (",60");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "");
            Assert.AreEqual(testInput.SplitCurrency[1], "60");
        }

        [TestMethod]
        public void CurrencyInputSplitSubUnit()
        {
            string input = ("0,60");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "0");
            Assert.AreEqual(testInput.SplitCurrency[1], "60");
        }

        //Tests to ensure correct conversion

        [TestMethod]
        public void CurrencyInputBaseEmpty()
        {
            List<string> input = new List<string>() { "" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseCorrect()
        {
            List<string> input = new List<string>() { "50" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseandSubEmpty()
        {
            List<string> input = new List<string>() { "", "" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseandSubCorrect()
        {
            List<string> input = new List<string>() { "23131", "43" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
            Assert.IsTrue(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseCorrectandSubEmpty()
        {
            List<string> input = new List<string>() { "231", "" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseEmptyandSubCorrect()
        {
            List<string> input = new List<string>() { "", "23" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
            Assert.IsTrue(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputTooManyCoomas()
        {
            List<string> input = new List<string>() { "", "23", "35" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputLettersBase()
        {
            List<string> input = new List<string>() { "fefe32" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
        }

        [TestMethod]
        public void CurrencyInputLettersSubUnit()
        {
            List<string> input = new List<string>() { "0", "fefe32" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputPunctuationSubUnit()
        {
            List<string> input = new List<string>() { "0", "?" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputOneDecimalSubUnit()
        {
            List<string> input = new List<string>() { "0", "1" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsTrue(testInput.ConvertBaseSuccess);
            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseTooLong()
        {
            List<string> input = new List<string>() { "1999999999" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertBaseSuccess);
        }

        [TestMethod]
        public void CurrencyInputSubUnitTooLong()
        {
            List<string> input = new List<string>() { "0", "999" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }

        [TestMethod]
        public void CurrencyInputBaseUnitNegative()
        {
            List<string> input = new List<string>() { "-50", "999" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();
            testInput.ConvertInput(input);

            Assert.IsFalse(testInput.ConvertSubUnitSuccess);
        }
    }
}
