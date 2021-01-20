using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppHashes
{
    class TestFromSite
    {
        private static string result = "default";

        static public string main()
        {
            Console.WriteLine("main, befor SaySomething. Task.CurrentId: " + Task.CurrentId);
            SaySomething();
            Console.WriteLine("main, after SaySomething. Task.CurrentId: " + Task.CurrentId);
            Console.WriteLine(result);
            return "dummy";
        }

        static async Task<string> SaySomething()
        {
            Console.WriteLine("SaySomething, befor Task.Delay. Task.CurrentId: " + Task.CurrentId);
            await Task.Delay(5);
            //Thread.Sleep(5);
            Console.WriteLine("SaySomething, after Task.Delay. Task.CurrentId: " + Task.CurrentId);

            result = "Hello world!";
            return "Something";
        }
    }
}
