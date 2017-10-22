using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class DollarOutput : ICurrencyOutput
    {
        public StringBuilder DollarCurrencyBuilder { get { return dollarCurrencyBuilder; } }

        string baseDenominationSingle = " dollar";
        string baseDenominationPlural = " dollars";
        string subUnitDenominationSingle = " cent";
        string subUnitDenominationPlural = " cents";

        StringBuilder dollarCurrencyBuilder = new StringBuilder();

        public void BaseStringBuilder(List<string> baseInput)
        {
            foreach (var item in baseInput)
            {
                dollarCurrencyBuilder.Append(item);
            }

            if (dollarCurrencyBuilder.ToString() == "one")
            {
                dollarCurrencyBuilder.Append(baseDenominationSingle);
            }
            else
            {
                dollarCurrencyBuilder.Append(baseDenominationPlural);
            }
        }

        public void SubUnitStringBuilder(List<string> subUnitInput)
        {
            dollarCurrencyBuilder.Append(" and ");
            
            foreach (var item in subUnitInput)
            {
                dollarCurrencyBuilder.Append(item);
            }

            if (subUnitInput[0] == "one")
            {
                dollarCurrencyBuilder.Append(subUnitDenominationSingle);
            }
            else
            {
                dollarCurrencyBuilder.Append(subUnitDenominationPlural);
            }
        }
    }
}
