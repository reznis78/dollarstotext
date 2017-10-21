using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarsToText
{
    public class DollarOutput : ICurrencyOutput
    {
        string baseDenominationSingle = " dollar";
        string baseDenominationPlural = " dollars";
        string subUnitDenominationSingle = " cent";
        string subUnitDenominationPlural = " cents";

        public void BaseStringBuilder(List<string> baseInput)
        {

        }

        public void SubUnitStringBuilder(List<string> subUnitInput)
        {

        }
    }
}
