using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
{
    public class DollarOutput : ICurrencyOutput
    {
        public StringBuilder DollarCurrencyBuilder { get { return dollarCurrencyBuilder; } }

        //By creating a new class and simply changing these values, you can easily output different currencies
        //Remember to leave in a leading space, for the StringBuilder
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("DollarOutput :")
                .Append("baseDenominationSingle : ").AppendLine(baseDenominationSingle)
                .Append("baseDenominationPlural : ").AppendLine(baseDenominationPlural)
                .Append("subUnitDenominationSingle : ").AppendLine(subUnitDenominationSingle)
                .Append("subUnitDenominationPlural : ").AppendLine(subUnitDenominationPlural)
                .Append("DollarCurrencyBuilder : ").AppendLine(DollarCurrencyBuilder.ToString());

            return result.ToString();
        }
    }
}
