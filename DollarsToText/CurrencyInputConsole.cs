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
        public bool ConvertBaseSuccess { get { return _convertBaseSuccess; } }
        public bool ConvertSubUnitSuccess { get { return _convertSubUnitSuccess; } }

        int baseUnit;
        int subUnit;

        bool _convertBaseSuccess = false;
        bool _convertSubUnitSuccess = false;

        string userInput;
        string _trimmedUserInput;

        List<string> _splitCurrency = new List<string>();

        public void CurrencyParser()
        {
            while (_convertBaseSuccess == false || _convertSubUnitSuccess == false)
            {
                GetInput();
                TrimUserInput(userInput);
                CurrencySplitInput(_trimmedUserInput);
                ConvertInput(_splitCurrency);
            }

            Console.WriteLine("Well Done");
        }

        public void TrimUserInput(string input)
        {
            _trimmedUserInput = input.Trim();
        }

        public void CurrencySplitInput(string input)
        {
            _splitCurrency = input.Split(',').ToList();
        }

        public void GetInput()
        {
            Console.WriteLine("Please enter a value:");
            userInput = Console.ReadLine();
        }

        public void ConvertInput(List<string> input)
        {
            if (input.Count >= 3)
            {
                Console.WriteLine("You have entered too many comma's, please try again");
            }
            if (input.Count == 2)
            {
                TryParseBaseUnit(input[0]);
                TryParseSubUnit(input[1]);
            }
            if (input.Count == 1)
            {
                TryParseBaseUnit(input[0]);
                _convertSubUnitSuccess = true;
            }
        }

        public void TryParseBaseUnit(string input)
        {
            _convertBaseSuccess = int.TryParse(input, out baseUnit);

            if (_convertBaseSuccess == false)
            {
                Console.WriteLine("You did not enter in a correct value, please try again.");
                _convertBaseSuccess = false;
            }
            else
            {
                _convertBaseSuccess = true;
            }
        }

        public void TryParseSubUnit(string input)
        {
            _convertSubUnitSuccess = int.TryParse(input, out subUnit);

            if (_convertSubUnitSuccess == false)
            {
                Console.WriteLine("You did not enter in a correct value, please try again.");
                _convertSubUnitSuccess = false;
            }
            else
            {
                _convertSubUnitSuccess = true;
            }
        }
    }
}
