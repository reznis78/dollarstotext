using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
{
    interface ICurrencyInput
    {
        void CurrencySplitInput(string userInput);
        void CurrencyParser();
        void TryParseBaseUnit(string input);
        void TryParseSubUnit(string input);
    }
}
