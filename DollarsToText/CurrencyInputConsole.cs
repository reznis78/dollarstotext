using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class CurrencyInputConsole : ICurrencyInput
    {
        protected bool success = false;
        string[] splitCurrency;
        string[] baseCurrency;
        string userInput;


        public void CurrencySplitInput(string userInput)
        {
            userInput.Trim();

            if (userInput.Contains(","))
            {
                string[] splitCurrency = userInput.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
