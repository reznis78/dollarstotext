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
        /*[TestMethod]
        public void CurrencyInputNull()
        {
            string input = ("");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }*/

        [TestMethod]
        public void CurrencyInputTrim()
        {
            string input = ("  1234,56  ");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.TrimUserInput(input);

            Assert.AreEqual(testInput.TrimmedUserInput, "1234,56");
        }

        [TestMethod]
        public void CurrencyInputSplit()
        {
            string input = ("123,45");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            Assert.AreEqual(testInput.SplitCurrency[0], "123");
        }

        /*[TestMethod]
        public void CurrencyInputLettersBase()
        {
            string input = ("21te");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputLettersSubUnit()
        {
            string input = ("0,4t");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputPunctuationSubUnit()
        {
            string input = ("0,?");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputBaseLimit()
        {
            string input = ("9999999999");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputSubUnitLimit()
        {
            string input = ("0,999");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputOnlyBase()
        {
            string input = ("99");

            CurrencyInputNull(input);

            Assert.AreEqual(input, "99");
        }

        [TestMethod]
        public void CurrencyInputOnlyUnit()
        {
            string input = ("0,99");

            CurrencyInputNull(input);

            Assert.AreEqual(input, "0,99");
        }

        [TestMethod]
        public void CurrencyInputOnlyUnit()
        {
            string input = ("0,99");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }*/
    }
}
