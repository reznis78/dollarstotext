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
        public string[] SplitCurrency { get { return _splitCurrency;  } }

        string _trimmedUserInput;
        string[] _splitCurrency;       
        public void TrimUserInput(string userInput)
        {
            _trimmedUserInput = userInput.Trim();
        }

        public string[] CurrencySplitInput(string _trimmedUserInput)
        {
            string[] _splitCurrency = _trimmedUserInput.Split(new string[] { "," }, StringSplitOptions.None);
            return _splitCurrency;
        }

        public void CurrencyParser(string userInput)
        {

        }
    }
}
