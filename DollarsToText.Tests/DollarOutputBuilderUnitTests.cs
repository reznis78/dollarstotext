using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText.Tests
{
    [TestClass]
    public class DollarOutputBuilderUnitTests
    {
        [TestMethod]
        public void StringBuilderOneBaseOnly()
        {
            List<string> input = new List<string>() { "one" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "one dollar");
        }

        [TestMethod]
        public void StringBuilderZeroBaseOnly()
        {
            List<string> input = new List<string>() { "zero" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "zero dollars");
        }

        [TestMethod]
        public void StringBuilderBaseOnly()
        {
            List<string> input = new List<string>() { "five", " hundred and ", "five" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "five hundred and five dollars");
        }

        [TestMethod]
        public void StringBuilderBaseWithOneSubUnit()
        {
            List<string> baseInput = new List<string>() { "five", " hundred and ", "five" };
            List<string> subUnitInput = new List<string>() { "one" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(baseInput);
            testOutput.SubUnitStringBuilder(subUnitInput);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "five hundred and five dollars and one cent");
        }

        [TestMethod]
        public void StringBuilderOneBaseWithSubUnit()
        {
            List<string> baseInput = new List<string>() { "one" };
            List<string> subUnitInput = new List<string>() { "twenty" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(baseInput);
            testOutput.SubUnitStringBuilder(subUnitInput);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "one dollar and twenty cents");
        }

        [TestMethod]
        public void StringBuilderBaseWithSubUnitWithHyphen()
        {
            List<string> baseInput = new List<string>() { "ninety", "-", "five" };
            List<string> subUnitInput = new List<string>() { "twenty", "-", "three" };

            DollarOutputBuilder testOutput = new DollarOutputBuilder();

            testOutput.BaseStringBuilder(baseInput);
            testOutput.SubUnitStringBuilder(subUnitInput);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "ninety-five dollars and twenty-three cents");
        }

    }
}
