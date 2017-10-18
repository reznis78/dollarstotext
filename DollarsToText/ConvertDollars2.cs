using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class ConvertDollars2
    {
        public static string[] basicUnits =
                {
                "",
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
                "",
                "",
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

        public void ConvertCurrency(int currencyValue)
        {
            if (currencyValue == 0)
            {
                _currencyString.Add("zero");
                _currencyString.Add(" dollars");
            }

            if (currencyValue == 1)
            {
                _currencyString.Add(basicUnits[currencyValue]);
                _currencyString.Add(" dollar");
            }

            if ((currencyValue < 20) && (currencyValue > 1))
            {
                _currencyString.Add(basicUnits[currencyValue]);
                _currencyString.Add(" dollars");
            }

            if ((currencyValue < 99) && (currencyValue > 20))
            {
                ConvertTens(currencyValue);
                _currencyString.Add(" dollars");
            }

            if ((currencyValue < 999) && (currencyValue > 100))
            {
                ConvertHundreds(currencyValue);
                _currencyString.Add(" dollars");
            }

            if ((currencyValue < 999999) && (currencyValue > 1000))
            {
                ConvertThousands(currencyValue);
                _currencyString.Add(" dollars");
            }
        }

        public void ConvertTens(int currencyValue)
        {
            _currencyString.Add(largeUnits[(currencyValue / 10) - 1]);

            if (currencyValue % 10 != 0)
            {
                _currencyString.Add(basicUnits[currencyValue % 10]);
            }
            
        }

        public void ConvertHundreds(int currencyValue)
        {
            _currencyString.Add(basicUnits[(currencyValue / 100)]);
            
            if (currencyValue % 100 == 0)
            {
                _currencyString.Add(" hundred");
            }
            else
            {
                _currencyString.Add(" hundred and ");
            }

            currencyValue = currencyValue % 100;

            if (currencyValue > 20)
            {
                ConvertTens(currencyValue);
            }

            if (currencyValue < 20 && currencyValue > 1)
            {
                _currencyString.Add(basicUnits[currencyValue]);
            }
        }

        public void ConvertThousands(int currencyValue)
        {
            if ((currencyValue / 1000) > 99)
            {
                int adjustedValue = currencyValue / 1000;
                ConvertHundreds(adjustedValue);
            }

            if (((currencyValue / 1000) < 100) && ((currencyValue / 1000) > 20))
            {
                int adjustedValue = currencyValue / 1000;
                ConvertTens(adjustedValue);
            }

            if ((currencyValue / 1000) < 21)
            {
                _currencyString.Add(basicUnits[currencyValue / 1000]);
            }

            if (currencyValue % 1000 == 0)
            {
                _currencyString.Add(" thousand");
            }
            else
            {
                _currencyString.Add(" thousand ");
            }    

            currencyValue = currencyValue % 1000;

            ConvertHundreds(currencyValue);
        }
    }
}
