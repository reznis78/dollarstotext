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
            int currencyValue = 4798;

            ConvertDollars2 testDollars = new ConvertDollars2();

            testDollars.ConvertCurrency(currencyValue);

            foreach (var item in testDollars.CurrencyString)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
