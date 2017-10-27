using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
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
                GetConsoleInput();
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

        public void GetConsoleInput()
        {
            Console.WriteLine("Please enter a value and press enter to convert:");
            userInput = Console.ReadLine();
        }

        public void ConvertInput(List<string> input)
        {
            //Prevents the user from entering multiple comma's
            if (input.Count >= 3)
            {
                Console.WriteLine("You have entered too many comma's, please try again");
            }

            if (input.Count == 2)
            {

                TryParseBaseUnit(input[0]);

                //Ensures that the user cannot enter ,3 or ,004, for example
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

            //Determines that there is only a base unit, thus the sub unit success flag must also be set to true
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

        void CheckBaseIntSize(int input)
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

        void CheckSubUnitIntSize(int input)
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("CurrencyInputConsole :")
                .Append("TrimmedUserInput : ").AppendLine(TrimmedUserInput)
                .Append("ConvertBaseSuccess : ").AppendLine(ConvertBaseSuccess.ToString())
                .Append("ConvertSubUnitSuccess : ").AppendLine(ConvertSubUnitSuccess.ToString())
                .Append("BaseUnit : ").AppendLine(BaseUnit.ToString())
                .Append("SubUnit : ").AppendLine(SubUnit.ToString());

            if (SplitCurrency != null)
            {
                result.AppendLine("SplitCurrency : ");
                foreach (var item in SplitCurrency)
                {
                    result.Append(item).Append(", ");
                }
            }

            return result.ToString();
        }
    }
}
