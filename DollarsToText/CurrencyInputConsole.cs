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

        //Core Method that keeps the user in a loop until the inputs are correct
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
                baseUnit = -1;
            }
            
            CheckBaseIntSize(baseUnit);    
        }

        public void TryParseSubUnit(string input)
        {
            _convertSubUnitSuccess = int.TryParse(input, out subUnit);

            if (_convertSubUnitSuccess == false)
            {
                subUnit = 0;
            }
            
            CheckSubUnitIntSize(subUnit);
        }

        public void CheckBaseIntSize(int input)
        {
            if (baseUnit < 999999999 && baseUnit >= 0)
            {
                _convertBaseSuccess = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid value for base unit between 0 and 999999999");
                _convertBaseSuccess = false;
            }
        }

        public void CheckSubUnitIntSize(int input)
        {
            if (subUnit < 99 && subUnit > 0)
            {
                _convertSubUnitSuccess = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid value for sub unit between 0 and 99");
                _convertSubUnitSuccess = false;
            }
        }
    }
}
