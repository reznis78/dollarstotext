using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    interface ICurrencyInput
    {
        string[] CurrencySplitInput(string userInput);
        void CurrencyParser(string currencyInput);
    }
}
