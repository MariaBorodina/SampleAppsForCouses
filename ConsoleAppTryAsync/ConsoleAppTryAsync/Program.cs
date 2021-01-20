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

            //CallAsyncAwait();
            CallTaskWhen();
            //CallTaskWait();
            //CallTaskContinueWith();
            //CallTaskDoSomeWork();

            Console.WriteLine("After the call");

            Console.ReadLine();

        }


        static void CallTaskWhen()
        {
            Console.WriteLine("Going to create task");
            Task<string> task = CallTaskReturnTask();
            Thread.Sleep(200);

            Console.WriteLine("Going to WhenAny... ");
            var after = Task.WhenAny(task);
            Thread.Sleep(200);

            Console.WriteLine("Going to wait... ");
            after.Wait();
            Console.WriteLine("Right after the wait ");
            Thread.Sleep(200);

            Console.WriteLine("after.Result = " + after.Result.Result);
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
