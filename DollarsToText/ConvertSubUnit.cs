using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class ConvertSubUnit : IConvertCurrencyToText
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
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety",
                };

        public List<string> SubUnitString { get { return _subUnitString; } }

        protected List<string> _subUnitString = new List<string>();

        public virtual void ConvertCurrency(int currencyValue)
        {
            if (currencyValue == 0)
            {
                _subUnitString.Add("zero");
            }

            if ((currencyValue == 1) && (_subUnitString.Count == 0))
            {
                _subUnitString.Add(basicUnits[currencyValue]);
                currencyValue = 0;
            }

            if ((currencyValue <= 20) && (currencyValue >= 1))
            {
                _subUnitString.Add(basicUnits[currencyValue]);
            }

            if ((currencyValue <= 99) && (currencyValue > 20))
            {
                ConvertTens(currencyValue);
            }
        }

        public virtual void ConvertTens(int currencyValue)
        {
            _subUnitString.Add(largeUnits[(currencyValue / 10) - 1]);

            if (currencyValue % 10 != 0)
            {
                _subUnitString.Add("-");
                _subUnitString.Add(basicUnits[currencyValue % 10]);
            }
        }
    }
}
