using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
{
    public class ConvertCurrencyEnglish : IConvertCurrencyToText
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

        public List<string> UnitString { get { return _unitString; } }

        protected List<string> _unitString = new List<string>();

        public void ConvertCurrency(int currencyValue)
        {
            if (currencyValue == 0)
            {
                _unitString.Add("zero");
            }

            if ((currencyValue == 1) && (_unitString.Count == 0))
            {
                _unitString.Add(basicUnits[currencyValue]);
                currencyValue = 0;
            }

            if ((currencyValue <= 20) && (currencyValue >= 1))
            {
                _unitString.Add(basicUnits[currencyValue]);
            }

            if ((currencyValue <= 99) && (currencyValue > 20))
            {
                ConvertTens(currencyValue);
            }

            if ((currencyValue <= 999) && (currencyValue >= 100))
            {
                ConvertHundreds(currencyValue);
            }

            if ((currencyValue <= 999999) && (currencyValue >= 1000))
            {
                ConvertThousands(currencyValue);
            }

            if ((currencyValue <= 999999999) && (currencyValue >= 1000000))
            {
                ConvertMillions(currencyValue);
            }
        }

        public void ConvertTens(int currencyValue)
        {
            _unitString.Add(largeUnits[(currencyValue / 10) - 1]);

            if (currencyValue % 10 != 0)
            {
                _unitString.Add("-");
                _unitString.Add(basicUnits[currencyValue % 10]);
            }
            
        }

        //If editing the word values below, then take care with the spaces
        public void ConvertHundreds(int currencyValue)
        {
            _unitString.Add(basicUnits[(currencyValue / 100)]);
            
            if (currencyValue % 100 == 0)
            {
                _unitString.Add(" hundred");
            }
            else
            {
                _unitString.Add(" hundred ");
            }

            currencyValue = currencyValue % 100;

            if (currencyValue > 20)
            {
                ConvertTens(currencyValue);
            }

            if (currencyValue <= 20 && currencyValue >= 1)
            {
                _unitString.Add(basicUnits[currencyValue]);
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

            if ((currencyValue / 1000) <= 20)
            {
                _unitString.Add(basicUnits[currencyValue / 1000]);
            }

            if (currencyValue % 1000 == 0)
            {
                _unitString.Add(" thousand");
            }
            else
            {
                _unitString.Add(" thousand ");
                currencyValue = currencyValue % 1000;
                ConvertCurrency(currencyValue);
            }    

            
        }

        public void ConvertMillions(int currencyValue)
        {
            if ((currencyValue / 1000000) > 99)
            {
                int adjustedValue = currencyValue / 1000000;
                ConvertHundreds(adjustedValue);
            }

            if (((currencyValue / 1000000) < 100) && ((currencyValue / 1000000) > 20))
            {
                int adjustedValue = currencyValue / 1000000;
                ConvertTens(adjustedValue);
            }

            if ((currencyValue / 1000000) <= 20)
            {
                _unitString.Add(basicUnits[currencyValue / 1000000]);
            }

            if (currencyValue % 1000000 == 0)
            {
                _unitString.Add(" million");
            }
            else
            {
                _unitString.Add(" million ");
                currencyValue = currencyValue % 1000000;
                ConvertCurrency(currencyValue);
            }           
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (UnitString != null)
            {
                result.Append("ConvertBaseCurrency: ");
                foreach (var item in UnitString)
                {
                    result.Append(item).Append(", ");
                }
            }
            return result.ToString();
        }
    }
}
