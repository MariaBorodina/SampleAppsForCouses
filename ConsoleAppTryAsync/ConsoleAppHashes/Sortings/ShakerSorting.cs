using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes.Sortings
{
    class ShakerSorting : SortingBase
    {
        public ShakerSorting(int len, int maxValue) : base(len, maxValue) { }
        public override int Sort()
        {
            int ops = 0;

            for (int iStart = 0, iFinish = Values.Length-1; iStart < iFinish; )
            {
                for (int j = iStart; j < iFinish; j++)
                    if (WrongOrder(Values[j], Values[j + 1]))
                        Swap(ref Values[j], ref Values[j + 1], ref ops);
                iFinish--;

                for (int j = iFinish; j > iStart; j--)
                    if (WrongOrder(Values[j - 1], Values[j]))
                        Swap(ref Values[j-1], ref Values[j], ref ops);
                iStart++;
            }

            return ops;
        }

    }
}
