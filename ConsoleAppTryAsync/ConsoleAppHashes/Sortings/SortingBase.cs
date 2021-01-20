using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppHashes.Sortings
{
    abstract class SortingBase
    {
        public int[] Values;
        private int MaxValue;

        public SortingBase(int len, int maxValue)
        {
            Values = new int[len];
            MaxValue = maxValue;
            WrongOrder = (a, b) => a > b;

            Init();
        }

        public abstract int Sort();
        


        private void Init()
        {
            Random r = new Random(2);
            for (int i = 0; i < Values.Length; i++)
                Values[i] = r.Next(MaxValue);
        }

        protected void Swap(ref int i, ref int j, ref int counter)
        {
            var s = i;
            i = j;
            j = s;
            counter++;
        }

        public string Print() => Print(Values);

        public string Print(int[] values) => Print(values, 0, values.Length);

        public string Print(int[] values, int iStart, int iLength)
        {
            var sb = new StringBuilder(iLength * 2);

            for (int i = iStart; i < iStart + iLength; i++)
                sb.Append(values[i] + ", ");

            if (sb.Length > 2)
                sb.Remove(sb.Length - 2, 2);

            return sb.ToString();
        }

        public Func<int, int, bool> WrongOrder;

        public bool IsOrdered 
        { 
            get
            {
                for(var i = 0; i < Values.Length - 1; i++)
                    if(WrongOrder(Values[i], Values[i+1]))
                        return false;

                return true;
            }
        }
    }


}
