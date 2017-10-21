using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> baseInput = new List<string>() { "five", "hundred", "and", "five" };
            List<string> subUnitInput = new List<string>() { "one" };

            DollarOutput testOutput = new DollarOutput();

            testOutput.BaseStringBuilder(baseInput);
            testOutput.SubUnitStringBuilder(subUnitInput);

            Console.WriteLine(testOutput.DollarCurrencyBuilder);
        }
    }
}
