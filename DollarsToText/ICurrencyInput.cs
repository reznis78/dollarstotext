using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    interface ICurrencyInput
    {
        void CurrencyInput(string userInput);
        List<int> CurrencyParser(string currencyInput);
    }
}
