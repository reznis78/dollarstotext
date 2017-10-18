using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class ConvertDollars : IConvertNumberToText
    {
        public static string[] basicUnits =
                {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen",
                "twenty"
                };

        public static string[] largeUnits =
                {
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety",
                };

        public List<string> CurrencyString { get { return _currencyString; } }

        protected List<string> _currencyString = new List<string>();

        protected int hundreds;
        protected int tens;
        protected int basic;

        public void ConvertCurrency(int currencyValue)
        {
            if (currencyValue == 0)
            {
                _currencyString.Add(basicUnits[currencyValue]);
            }

            if ((currencyValue > 99) && (currencyValue < 1000))
            {
                ConvertHundreds(currencyValue);                
            }

            if ((currencyValue > 20) && (currencyValue < 100))
            {
                ConvertTens(currencyValue);
            }

            if ((currencyValue > 0) && (currencyValue < 20))
            {
                _currencyString.Add(basicUnits[currencyValue]);
            }

        }

        public void ConvertHundreds(int currencyValue)
        {
            hundreds = currencyValue / 100;
            currencyValue = currencyValue - (hundreds * 100);
            _currencyString.Add(basicUnits[hundreds]);
            if (currencyValue == 0)
            {
                _currencyString.Add("");
                _currencyString.Add("");
            }

            if ((currencyValue < 100) && (currencyValue > 20))
            {
                ConvertTens(currencyValue);
            }

            if ((currencyValue < 20) && (currencyValue > 0))
            {
                _currencyString.Add("");
                _currencyString.Add(basicUnits[currencyValue]);
            }
        }

        public void ConvertTens(int currencyValue)
        {
            tens = currencyValue / 10;
            basic = currencyValue % 10;

            if (basic == 0)
            {
                _currencyString.Add("");
            }
            if (tens > 20)
            {
                _currencyString.Add(largeUnits[tens - 3]);
                _currencyString.Add(basicUnits[basic]);
            }

            _currencyString.Add(largeUnits[tens - 3]);
            _currencyString.Add(basicUnits[basic]);
        }
    }
}
