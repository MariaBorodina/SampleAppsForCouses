using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashes.Sortings
{
    class QuickSorting : SortingBase
    {
        public QuickSorting(int len, int maxValue) : base(len, maxValue) { }

        public override int Sort()
        {
           return SortPartition(0, Values.Length);
        }


        private int SortPartition(int iStart, int iLength, int depth = 0)
        {
            if (iLength <= 1)
                return 0;

            Console.WriteLine($"Sorting from {iStart}, {iLength} elements, recusion depth = {depth}: {Print(Values, iStart, iLength)}");

            int ops = 0;
            int basicElement = Values[iStart];
            int nextMovedIndex = iStart;

            for (int i = iStart + 1; i < iStart + iLength; i++)
            {
                if (WrongOrder(basicElement, Values[i]))
                {
                    Swap(ref Values[i], ref Values[++nextMovedIndex], ref ops);
                }
            }
            Swap(ref Values[iStart], ref Values[nextMovedIndex], ref ops);

            if (nextMovedIndex > iStart + 1)
                ops += SortPartition(iStart, nextMovedIndex - iStart, depth+1);

            if (nextMovedIndex < iStart + iLength + 1)
                ops += SortPartition(nextMovedIndex + 1, iStart + iLength - nextMovedIndex - 1, depth + 1);

            return ops;
        }
    }
}
