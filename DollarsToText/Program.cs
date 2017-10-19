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
            string userInput = ("123,45");

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencySplitInput(userInput);

            foreach (var item in testInput.SplitCurrency)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
