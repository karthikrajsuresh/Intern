using System;
using System.Threading;
using System.Threading.Tasks;

class peoblem
{
    public static void SimpleThread()
    {
        Thread thread = new Thread(new ThreadStart(WriteToConsole));
        thread.Start();
        thread.Join();
    }

    public static void WriteToConsole()
    {
        Console.WriteLine("Hello from a thread!");
    }

    public static void ThreadWithParameter()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(WriteToConsoleWithParam));
        thread.Start("Hello with parameter!");
        thread.Join();
    }

    public static void WriteToConsoleWithParam(object message)
    {
        Console.WriteLine(message);
    }

    public static void ThreadSynchronization()
    {
        object lockObject = new object();
        int counter = 0;

        void Increment()
        {
            lock (lockObject)
            {
                counter++;
                Console.WriteLine("Counter: " + counter);
            }
        }

        Thread thread1 = new Thread(new ThreadStart(Increment));
        Thread thread2 = new Thread(new ThreadStart(Increment));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }

    public static void UseThreadPool()
    {
        ThreadPool.QueueUserWorkItem(state => Console.WriteLine("Hello from thread pool!"));
    }

    public static void SimpleTask()
    {
        Task task = Task.Run(() => Console.WriteLine("Hello from a task!"));
        task.Wait();
    }

    public static void TaskWithResult()
    {
        Task<int> task = Task.Run(() => {
            Thread.Sleep(1000);
            return 42;
        });
        Console.WriteLine("Task result: " + task.Result);
    }

    public static async Task UseAsyncAwait()
    {
        int result = await Task.Run(() => {
            Thread.Sleep(1000);
            return 42;
        });
        Console.WriteLine("Async result: " + result);
    }

    public static async Task UseConfigureAwait()
    {
        int result = await Task.Run(() => {
            Thread.Sleep(1000);
            return 42;
        }).ConfigureAwait(false);
        Console.WriteLine("ConfigureAwait result: " + result);
    }

    public static void ParallelFor()
    {
        Parallel.For(0, 10, i => {
            Console.WriteLine($"Parallel loop iteration: {i}");
        });
    }

    public static void UseCancellationToken()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        Task task = Task.Run(() => {
            for (int i = 0; i < 10; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Task canceled.");
                    return;
                }
                Console.WriteLine($"Working... {i}");
                Thread.Sleep(500);
            }
        }, token);

        Thread.Sleep(1000);
        cts.Cancel();
        task.Wait();
    }
}

