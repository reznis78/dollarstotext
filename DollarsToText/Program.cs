using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1234,45";

            List<string> splitCurrency = input.Split(',').ToList();

            foreach (var item in splitCurrency)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
