using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Currency Conversion Program v1.0
 * Nathan Uhl
 * A simple program to convert a number value to a text value
 */

namespace CurrencyNumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the currency converter, you can convert from a number to words.\n" +
                "Please enter in your number either as a base unit, for instance 5, this will then become five dollars.\n" +
                "In order to use a sub unit like cents, please enter in a comma, for instance 0,45, this will become zero dollars and forty-five cents.\n" +
                "The maximum base unit is 999999999 and the maximum sub-unit is 99.");

            //Generates the console input prompt and provides input checking
            CurrencyInputConsole getUserInput = new CurrencyInputConsole();

            getUserInput.CurrencyParser();

            //Decision whether the parsed input is just a base unit or has a sub unit component and outputs the result
            if (getUserInput.SubUnit == 0)
            {
                ConvertCurrencyEnglish baseDollarsOnly = new ConvertCurrencyEnglish();
                DollarOutputBuilder baseDollarOutputOnly = new DollarOutputBuilder();

                baseDollarsOnly.ConvertCurrency(getUserInput.BaseUnit);

                baseDollarOutputOnly.BaseStringBuilder(baseDollarsOnly.UnitString);

                Console.WriteLine(baseDollarOutputOnly.DollarCurrencyBuilder);
            }
            else
            {
                ConvertCurrencyEnglish baseDollars = new ConvertCurrencyEnglish();
                ConvertCurrencyEnglish subUnitCents = new ConvertCurrencyEnglish();
                
                DollarOutputBuilder dollarAndCentsOutput = new DollarOutputBuilder();

                baseDollars.ConvertCurrency(getUserInput.BaseUnit);
                subUnitCents.ConvertCurrency(getUserInput.SubUnit);
                
                dollarAndCentsOutput.BaseStringBuilder(baseDollars.UnitString);
                dollarAndCentsOutput.SubUnitStringBuilder(subUnitCents.UnitString);

                Console.WriteLine(dollarAndCentsOutput.DollarCurrencyBuilder);
            }
        }
    }
}
