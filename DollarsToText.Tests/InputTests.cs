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
            string input("");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInput.Success);
        }

        [TestMethod]
        public void CurrencyInputTrim()
        {
            string input("  1234  ");

            CurrencyInputNull(input);

            Assert.AreEqual(CurrencyInput, 1234);
        }

        [TestMethod]
        public void CurrencyInputLettersBase()
        {
            string input("21te");

            CurrencyInputNull(input);

            Assert.AreEqual(CurrencyInput, 1234);
        }

        [TestMethod]
        public void CurrencyInputLettersSubUnit()
        {
            string input("21,4t");

            CurrencyInputNull(input);

            Assert.IsFalse(CurrencyInput.Success);
        }
    }
}
