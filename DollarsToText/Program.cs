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
                ConvertCurrencyEnglish dollarsOnly = new ConvertCurrencyEnglish();
                DollarOutputBuilder dollarOnlyOutputBuilder = new DollarOutputBuilder();

                dollarsOnly.ConvertCurrency(getUserInput.BaseUnit);

                dollarOnlyOutputBuilder.AddBaseString(dollarsOnly.UnitString);

                Console.WriteLine(dollarOnlyOutputBuilder.DollarCurrencyBuilder);
            }
            else
            {
                ConvertCurrencyEnglish dollars = new ConvertCurrencyEnglish();
                ConvertCurrencyEnglish cents = new ConvertCurrencyEnglish();
                
                DollarOutputBuilder dollarAndCentsOutputBuilder = new DollarOutputBuilder();

                dollars.ConvertCurrency(getUserInput.BaseUnit);
                cents.ConvertCurrency(getUserInput.SubUnit);
                
                dollarAndCentsOutputBuilder.AddBaseString(dollars.UnitString);
                dollarAndCentsOutputBuilder.AddSubUnitString(cents.UnitString);

                Console.WriteLine(dollarAndCentsOutputBuilder.DollarCurrencyBuilder);
            }
        }
    }
}
