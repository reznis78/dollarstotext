using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText.Tests
{
    [TestClass]
    class CompleteConversionTests
    {
        [TestMethod]
        public void OutputOneBaseOnly()
        {
            List<string> input = new List<string>() { "one" };

            DollarOutput testOutput = new DollarOutput();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "one dollar");
        }

        [TestMethod]
        public void OutputZeroBaseOnly()
        {
            List<string> input = new List<string>() { "zero" };

            DollarOutput testOutput = new DollarOutput();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "zero dollars");
        }

        [TestMethod]
        public void OutputSmallBaseOnly()
        {
            List<string> input = new List<string>() { "five" };

            DollarOutput testOutput = new DollarOutput();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "five dollars");
        }

        [TestMethod]
        public void OutputZeroBaseWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputTensBaseWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputTensRoundedWithoutSubUnit()
        {
            List<string> input = new List<string>() { "forty" };

            DollarOutput testOutput = new DollarOutput();

            testOutput.BaseStringBuilder(input);

            string result = testOutput.DollarCurrencyBuilder.ToString();

            Assert.AreEqual(result, "forty dollars");
        }

        [TestMethod]
        public void OutputTensRoundedWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputTensBaseWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputHundredsBaseWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputHundredsBaseWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputHundredsBaseRoundedWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputHundredsBaseRoundedWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputThousandsBaseWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputThousandsBaseWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputThousandsBaseRoundedWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputThousandsBaseRoundedWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputMillionsBaseWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputMillionsBaseWithoutSubUnit()
        {

        }

        [TestMethod]
        public void OutputMillionsBaseRoundedWithSubUnit()
        {

        }

        [TestMethod]
        public void OutputMillionsBaseRoundedWithoutSubUnit()
        {

        }

    }
}
