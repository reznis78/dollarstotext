using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class CurrencyInputConsole : ICurrencyInput
    {
        public string TrimmedUserInput { get { return _trimmedUserInput; } }
        public List<string> SplitCurrency { get { return _splitCurrency; } }

        string _trimmedUserInput;
        List<string> _splitCurrency = new List<string>();

        public void TrimUserInput(string input)
        {
            _trimmedUserInput = input.Trim();
        }

        public void CurrencySplitInput(string input)
        {
            _splitCurrency = _trimmedUserInput.Split(',').ToList();
            _splitCurrency.Add("45");

        }

        public void CurrencyParser(string userInput)
        {

        }
    }
}
