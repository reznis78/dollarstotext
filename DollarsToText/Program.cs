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
            int baseDollarValue = 1321321;
            int subUnitValue = 25;

            ConvertBaseCurrency baseDollars = new ConvertBaseCurrency();
            ConvertSubUnit subUnitCents = new ConvertSubUnit();

            baseDollars.ConvertCurrency(baseDollarValue);
            subUnitCents.ConvertCurrency(subUnitValue);

            DollarOutput getDollarsInText = new DollarOutput();

            getDollarsInText.BaseStringBuilder(baseDollars.BaseCurrencyString);
            getDollarsInText.SubUnitStringBuilder(subUnitCents.SubUnitString);

            Console.WriteLine(getDollarsInText.DollarCurrencyBuilder);
        }
    }
}
