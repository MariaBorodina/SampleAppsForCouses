using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTryAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Fun With Async ===>");

            //await CallAsyncAwait();
            //CallTaskWhen();
            //CallTaskWait();
            //CallTaskContinueWith();
            CallTaskDoSomeWork();


            //var c = new TestSomeAsync();
            //c.CallTaskWhen();
            Console.WriteLine("After the call");

            Console.ReadKey();

        }

        static int i = 1;
        static string str = "a";
        static void CallTaskWhen()
        {
            i = 2;
            str = "b";

            Console.WriteLine(DateTime.Now.ToLongTimeString() + " Going to create task");

            Task<string> task = CallTaskReturnTask();

            Console.WriteLine("i = " + i + ", str = " + str);
            Thread.Sleep(200);
            Console.WriteLine("i = " + i + ", str = " + str);

            Console.WriteLine(DateTime.Now.ToLongTimeString() + " Going to WhenAny... ");
            var after = Task.WhenAny(task);
            Console.WriteLine("i = " + i + ", str = " + str);
            Thread.Sleep(200);

            Console.WriteLine(DateTime.Now.ToLongTimeString() + " Going to wait... ");
            after.Wait();
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " Right after the wait ");
            Thread.Sleep(200);

            Console.WriteLine(DateTime.Now.ToLongTimeString() + " after.Result = " + after.Result.Result);
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " i = " + i + ", str = " + str);
        }

        static void CallTaskDoSomeWork()
        {
            var task = CallTaskReturnTask();
            Console.WriteLine("Started task, task.Status = " + task.Status);

            Thread.Sleep(200);

            Console.WriteLine("Doing some work as if... ");

            task.Wait();
            

            Console.WriteLine("task.Result = " + task.Result);
        }

        static Task<string> CallTaskReturnTask()
        {
            Task<string> task = Task.Run(() =>
            {
                Console.WriteLine("task started");
                i = 5;
                str = "changed";
                Thread.Sleep(2_000);
                Console.WriteLine("Done some work in task ");
                return "The message from CallTask!";
            });

            return task;
        }



        static void CallTaskWait()
        {
            Console.WriteLine("Going to create task");
            Task<string> task = CallTaskReturnTask();
            Console.WriteLine("Going to wait ");

            task.Wait();

            Console.WriteLine("task.Result = " + task.Result);
        }

        static void CallTaskContinueWith()
        {
            Task<string> task = Task.Run(() =>
            {
                Thread.Sleep(2_000);
                return "The message from CallTask!";
            });

            task.ContinueWith((t) => Console.WriteLine("task.Result = " + t.Result));         
        }


        static async Task CallAsyncAwait()
        {
            string message = await DoWorkAsync(); 
            Console.WriteLine(message);
            Console.WriteLine("Completed"); 
        }

        static async Task<string> DoWorkAsync() 
        { 
            return await Task.Run(() => 
            { 
                Thread.Sleep(2_000); 
                return "The message from DoWork!"; 
            }); 
        }
    }
}
