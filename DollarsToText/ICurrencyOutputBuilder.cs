using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
{
    public interface ICurrencyOutputBuilder
    {
        void BaseStringBuilder(List<string> baseInput);
        void SubUnitStringBuilder(List<string> subUnitInput);
    }
}
