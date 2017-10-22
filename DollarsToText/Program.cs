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
            Console.WriteLine("Welcome to the currency converter, you can convert from a number to words.\n" +
                "Please enter in your number either as a base unit, for instance 5, this will then become five dollars.\n" +
                "In order to use a sub unit like cents, please enter in a comma, for instance 0,45, this will become zero dollars and forty-five cents.\n" +
                "The maximum base unit is 999999999 and the maximum sub-unit is 99.");

            CurrencyInputConsole getUserInput = new CurrencyInputConsole();

            getUserInput.CurrencyParser();

            if (getUserInput.SubUnit == 0)
            {
                ConvertBaseCurrency baseDollarsOnly = new ConvertBaseCurrency();
                DollarOutput baseDollarOutputOnly = new DollarOutput();

                baseDollarsOnly.ConvertCurrency(getUserInput.BaseUnit);

                baseDollarOutputOnly.BaseStringBuilder(baseDollarsOnly.BaseCurrencyString);

                Console.WriteLine(baseDollarOutputOnly.DollarCurrencyBuilder);
            }
            else
            {
                ConvertBaseCurrency baseDollars = new ConvertBaseCurrency();
                ConvertSubUnit subUnits = new ConvertSubUnit();

                DollarOutput dollarAndCentsOutput = new DollarOutput();

                baseDollars.ConvertCurrency(getUserInput.BaseUnit);
                subUnits.ConvertCurrency(getUserInput.SubUnit);

                dollarAndCentsOutput.BaseStringBuilder(baseDollars.BaseCurrencyString);
                dollarAndCentsOutput.SubUnitStringBuilder(subUnits.SubUnitString);

                Console.WriteLine(dollarAndCentsOutput.DollarCurrencyBuilder);
            }
            
        }
    }
}
