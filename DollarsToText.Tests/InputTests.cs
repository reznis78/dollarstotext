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
        [TestMethod]
        public void CurrencyInputNull()
        {
            string input = ("");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInputConsole.Success);
        }

        [TestMethod]
        public void CurrencyInputTrim()
        {
            string input = ("  1234  ");

            CurrencyInputNull(input);

            Assert.AreEqual(CurrencyInputConsole, "1234");
        }

        [TestMethod]
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
        }
    }
}
