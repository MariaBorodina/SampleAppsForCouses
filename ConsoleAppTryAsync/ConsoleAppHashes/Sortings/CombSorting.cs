using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes.Sortings
{
    class CombSorting : SortingBase
    {
        public CombSorting(int len, int maxValue, double? factor = null) : base(len, maxValue) 
        {
            if (factor != null)
                _factor = factor.Value;
        }

        private double _factor = 1.247;

        public override int Sort()
        {
            int ops = 0;

            for (int combLength = Values.Length; combLength >=1 && !IsOrdered; )
            {
                combLength = (combLength > 1) ? (int)((double)combLength / _factor) : 1;

                for (int j = 0; j >= 0 && j < Values.Length - combLength; j++)
                {
                    if (WrongOrder(Values[j], Values[j + combLength]))
                        Swap(ref Values[j], ref Values[j + combLength], ref ops);
                }

                Console.WriteLine($"CombLength = {combLength}");
            }
            return ops;
        }
    }
}
