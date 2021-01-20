using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnalizeList
{
    class TestSmthBase
    {
        private StringBuilder _responce;

        public string Responce
        {
            get { return _responce.ToString(); }
        }

        public TestSmthBase()
        {
            _responce = new StringBuilder(200);
            Log(this.GetType().Name);
        }

        public void Log(object o) => _responce.AppendLine($"{DateTime.Now.ToLongTimeString()}: {o}");
        public void Log(long? o) => _responce.AppendLine($"{DateTime.Now.ToLongTimeString()}: {(o ?? 0):N0}");

        public void Log(IEnumerable<int> array)
        {
            Log($"Array of {array.Count()} elements: ");
            Log(string.Join(", ", array));
        }


        private static Random _random = new Random(DateTime.Now.Millisecond);

        public static IEnumerable<int> GenerateIntArray(int count, int maxValue)
        {
            var res = new int[count];

            for (int i = 0; i < count; i++)
                res[i] = _random.Next(maxValue);

            return res;

            //for (int i = 0; i < count; i++) 
            //    yield return _random.Next(maxValue); // haha, this was unexpected! every time I used _the_same_ generated array, it contained different values!
        }

        public static double GenerateDouble(double maxValue)
        {
            return _random.NextDouble() * maxValue;
        }
    }
}
