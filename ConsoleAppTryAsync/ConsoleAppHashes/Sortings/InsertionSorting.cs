using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes.Sortings
{
    class InsertionSorting : SortingBase
    {
        public InsertionSorting(int len, int maxValue) : base(len, maxValue) { }

        public override int Sort()
        {
            int ops = 0;

            for (int i = 1; i < Values.Length; i++)
            {
                int x = Values[i];
                int j = i;

                while (j > 0 && Values[j - 1] > x)
                {
                    Values[j] = Values[--j];
                    ops++;
                }

                Values[j] = x;
            }

            return ops;
        }
    }
}
