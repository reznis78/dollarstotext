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
            List<string> input = new List<string>() { "","" };

            CurrencyInputConsole testInput = new CurrencyInputConsole();

            testInput.CurrencyParser();

            Console.ReadLine();
        }
    }
}
