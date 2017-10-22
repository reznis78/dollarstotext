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
        public int BaseUnit { get { return _baseUnit; } }
        public int SubUnit { get { return _subUnit; } }

        int _baseUnit;
        int _subUnit;

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
            Console.WriteLine("Please enter a value and press enter to convert:");
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

                //Checks that the sub unit value is not a single char, which means the input was .1 for example
                if (input[1].Length != 2)
                {
                    Console.WriteLine("You must enter two numbers for a sub unit");
                    _convertSubUnitSuccess = false;
                }
                else
                {
                    TryParseSubUnit(input[1]);
                }                
            }

            if (input.Count == 1)
            {
                TryParseBaseUnit(input[0]);
                _convertSubUnitSuccess = true;
            }
        }

        //The next two functions also includes a check 
        //to make sure that the resulting integer is not negative or too large
        public void TryParseBaseUnit(string input)
        {
            _convertBaseSuccess = int.TryParse(input, out _baseUnit);

            if (_convertBaseSuccess == false)
            {
                _baseUnit = -1;
            }
            
            CheckBaseIntSize(_baseUnit);    
        }

        public void TryParseSubUnit(string input)
        {
            _convertSubUnitSuccess = int.TryParse(input, out _subUnit);

            if (_convertSubUnitSuccess == false)
            {
                _subUnit = 0;
            }
            
            CheckSubUnitIntSize(_subUnit);
        }

        public void CheckBaseIntSize(int input)
        {
            if (_baseUnit < 999999999 && _baseUnit >= 0)
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
            if (_subUnit < 100 && _subUnit > 0)
            {
                _convertSubUnitSuccess = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid value for sub unit between 01 and 99");
                _convertSubUnitSuccess = false;
            }
        }
    }
}
