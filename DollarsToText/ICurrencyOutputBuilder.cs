using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNumberToText
{
    public interface ICurrencyOutputBuilder
    {
        void AddBaseString(List<string> baseInput);
        void AddSubUnitString(List<string> subUnitInput);
    }
}
