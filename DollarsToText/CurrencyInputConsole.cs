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

        int baseUnit;
        int subUnit;

        string _trimmedUserInput;
        List<string> _splitCurrency = new List<string>();

        public void TrimUserInput(string input)
        {
            _trimmedUserInput = input.Trim();
        }

        public void CurrencySplitInput(string input)
        {
            _splitCurrency = input.Split(',').ToList();
        }

        public void CurrencyParser(string input)
        {

        }

        public void CheckInputSize(List<string> input)
        {
            if (input.Count > 3)
            {
                Console.WriteLine("You have entered too many commas, please try again");
                // Get Input
            }
            if (input.Count == 2)
            {
                TryParseBaseUnit(input[0]);
                TryParseSubUnit(input[1]);
            }
        }

        public void TryParseBaseUnit(string input)
        {
            bool res = int.TryParse(input, out baseUnit);

            if (res == false)
            {
                //GetInput();
            }
        }

        public void TryParseSubUnit(string input)
        {
            bool res = int.TryParse(input, out subUnit);

            if (res == false)
            {
                //GetInput();
            }
        }
    }
}
