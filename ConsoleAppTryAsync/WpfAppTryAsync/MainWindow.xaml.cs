using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppTryAsync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Log(string str)
        {
            Dispatcher?.Invoke(() =>
            {
                var res = GeneralText.Text;
                res += "\n" + DateTime.Now.ToLongTimeString() + " " + str;
                GeneralText.Text = res;
            });
        }

        #region click events
        private void ButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            Log("print");
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Log("Cancel");
            this.Close();
        }


        private void ButtonDoAsyncAsTask_Click(object sender, RoutedEventArgs e)
        {
            Log("starting DoAsync as a new Task...");
            CallAsyncAwait(Log);
            Log("exit button click");
        }
        private async void ButtonDoAsyncAwait_Click(object sender, RoutedEventArgs e)
        {
            Log("starting DoAsync with await...");
            await CallAsyncAwait(Log);
            Log("exit button click");
        }

        private void ButtonDoAsyncWait_Click(object sender, RoutedEventArgs e)
        {
            Log("starting DoAsync with Wait task...");
            
            CallAsyncAwait(Log).Wait(); // hangs
            // CallTaskReturnTask().Wait(); // hangs

            Log("exit button click");
        }

        private void ButtonDoTaskResult_Click(object sender, RoutedEventArgs e)
        {
            Log("starting DoTask with Result task...");

            var str = CallTaskReturnTask().Result; // works, but blocks UI while the task is working
            // var str = CallAsyncAwait(Log).Result; // hangs
            Log(str);

            Log("exit button click");
        }

        private async void ButtonManyAsyncAwait_Click(object sender, RoutedEventArgs e)
        {
            Log("starting CallManyAsyncAwait with await...");
            var msg = await CallManyAsyncAwait(Log);
            Log(msg);
            Log("exit button click");
        }
        private async void ButtonManyAsyncWhenAll_Click(object sender, RoutedEventArgs e)
        {
            Log("starting DoAsync as a new Task...");
            var msg = await CallManyAsyncWhenAll(Log);
            Log(msg);
            Log("exit button click");
        }
        private void ButtonManyAsyncWaitAll_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region async work
        async Task<string> CallManyAsyncWhenAll(Action<string> logger)
        {
              StringBuilder builder = new StringBuilder("Result: ");
            var tasks = new List<Task<string>>();

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(CallTaskReturnTask(i, logger));
            }

            var res = await Task.WhenAll(tasks);

            builder.AppendJoin(';', res);
            logger("Completed");

            return builder.ToString();
        }

        async Task<string> CallManyAsyncAwait(Action<string> logger)
        {
            StringBuilder builder = new StringBuilder("Result:");

            for (int i = 0; i < 10; i++)
            {
                string message = await DoWorkAsync(i); //they will go one after the other is completed
                logger(message);
                builder.AppendFormat(" {0};", message);
            }
            builder.Remove(builder.Length - 1, 1);

            logger("Completed");
            return builder.ToString();
        }
        async Task<string> CallAsyncAwait(Action<string> logger)
        {
            string message = await DoWorkAsync();
            logger(message);
            logger("Completed");
            return message;
        }

        Random random = new Random(DateTime.Now.Millisecond);
        async Task<string> DoWorkAsync(int threadNumber = 0)
        {
            return await Task.Run(() =>
            {
                int sleep = random.Next(1000, 5000);
                Thread.Sleep(sleep);
                return $"The message from DoWork {threadNumber}: sleep = {sleep/1000}";
            });
        }

        private Task<string> CallTaskReturnTask(int threadNumber = 0, Action<string> logger = null)
        {
            Task<string> task = Task.Run(() =>
            {
                logger?.Invoke($"task {threadNumber} started");
                int sleep = random.Next(1000, 5000);
                Thread.Sleep(sleep);
                logger?.Invoke($"Done {sleep}ms of work in task {threadNumber}");
                return $"The message from CallTask {threadNumber}: sleep = {sleep / 1000}";
            });

            return task;
        }


        #endregion

    }
}
