using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleAppAnalizeList
{
    class TestSums : TestSmthBase 
    {
        internal long SumOfEvenIndexes(IEnumerable<int> array)
        {
            Log(MethodInfo.GetCurrentMethod().Name);

            var res = array.Where((element, index) => index % 2 == 0).Sum(i => (long)i);
            Log(res);

            return res;
        }

        internal long? SumOfEvens(IEnumerable<int> array)
        {
            Log(MethodInfo.GetCurrentMethod().Name);

            //var res = array.Where(i => i % 2 == 0) //quite good too
            //               .Select(i => (long)i)
            //               .Sum();

            var res = array.Sum(i => i % 2 == 0 ? (long?)i : null); //shortest way, and the site https://proglib.io/p/8-csharp-questions didn't know it!  

            Log(res);
            return res;
        }


    }
}
