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
            string input = "1234,45";

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(input);

            foreach (var item in testInput.SplitCurrency)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
