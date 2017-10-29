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

        int unitMultiplier;

        public void ConvertCurrency(int currencyValue)
        {
            if (currencyValue == 0)
            {
                _unitString.Add("zero");
            }

            if ((currencyValue == 1) && (_unitString.Count == 0))
            {
                AddBasicUnit(currencyValue);
                currencyValue = 0;
            }

            if ((currencyValue <= 20) && (currencyValue >= 1))
            {
                AddBasicUnit(currencyValue);
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
                unitMultiplier = 1000;
                ConvertLargeUnit(currencyValue, unitMultiplier);
            }

            if ((currencyValue <= 999999999) && (currencyValue >= 1000000))
            {
                unitMultiplier = 1000000;
                ConvertLargeUnit(currencyValue, unitMultiplier);
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
                AddBasicUnit(currencyValue);
            }
        }

        public void ConvertLargeUnit(int currencyValue, int unitMultiplier)
        {
            if ((currencyValue / unitMultiplier) > 99)
            {
                int adjustedValue = currencyValue / unitMultiplier;
                ConvertHundreds(adjustedValue);
            }

            if (((currencyValue / unitMultiplier) < 100) && ((currencyValue / unitMultiplier) > 20))
            {
                int adjustedValue = currencyValue / unitMultiplier;
                ConvertTens(adjustedValue);
            }

            if ((currencyValue / unitMultiplier) <= 20)
            {
                _unitString.Add(basicUnits[currencyValue / unitMultiplier]);
            }

            if ((currencyValue % unitMultiplier == 0) && (unitMultiplier == 1000))
            {
                _unitString.Add(" thousand");
            }

            if ((currencyValue % unitMultiplier != 0) && (unitMultiplier == 1000))
            {
                _unitString.Add(" thousand ");
                UpdateCurrencyValue(currencyValue);
            }

            if ((currencyValue % unitMultiplier == 0) && (unitMultiplier == 1000000))
            {
                _unitString.Add(" million");
            }

            if ((currencyValue % unitMultiplier != 0) && (unitMultiplier == 1000000))
            {
                _unitString.Add(" million ");
                UpdateCurrencyValue(currencyValue);
            }     
        }
        
        void UpdateCurrencyValue(int currencyValue)
        {
            currencyValue = currencyValue % unitMultiplier;
            ConvertCurrency(currencyValue);
        }

        void AddBasicUnit(int currencyValue)
        {
            _unitString.Add(basicUnits[currencyValue]);
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
