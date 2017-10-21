using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class DollarOutput : ICurrencyOutput
    {
        public StringBuilder BaseCurrencyBuilder { get { return baseCurrencyBuilder; } }
    
        string baseDenominationSingle = "dollar";
        string baseDenominationPlural = "dollars";
        string subUnitDenominationSingle = "cent";
        string subUnitDenominationPlural = "cents";

        StringBuilder baseCurrencyBuilder = new StringBuilder();

        public void BaseStringBuilder(List<string> baseInput)
        {
            foreach (var item in baseInput)
            {
                baseCurrencyBuilder.Append(item).Append(" ");
            }

            baseCurrencyBuilder.Append(baseDenominationSingle);

            Console.WriteLine(baseCurrencyBuilder);
        }

        public void SubUnitStringBuilder(List<string> subUnitInput)
        {

        }
    }
}
