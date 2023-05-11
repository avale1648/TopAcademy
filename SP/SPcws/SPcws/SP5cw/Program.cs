// See https://aka.ms/new-console-template for more information


namespace SP5cw
{
    using System;
    class Program
    {
        static void Main(string[] args) => new Program().MutexRun();
        private void MutexRun()
        {
            for (int i = 0; i < 4; i++)
                new Thread(Increment).Start();
            while (done < 4) ;
        }
        private void CountdownEventRun()
        {
            for (int i = 0; i < 4; i++)
                new Thread(IncrementA).Start();
            countdownEvent.Wait();
        }
        private int counter = 0, done = 0;
        private Mutex counterGuard = new Mutex();
        private Mutex doneGuard = new Mutex();
        private CountdownEvent countdownEvent = new CountdownEvent(4);
        private void Increment(object state)
        {
            for (int i = 0; i < 100_000; i++)
            {
                try
                {
                    counterGuard.WaitOne();
                    counter++;
                }
                finally
                {
                    counterGuard.ReleaseMutex(); 
                }
            }
            Console.WriteLine(counter);
            try
            {
                doneGuard.WaitOne();
                done++;
            }
            finally 
            {
                doneGuard.ReleaseMutex(); 
            }
        }
        private void IncrementA(object state)
        {
            for (int i = 0; i < 100_000; i++)
            {
                try
                {
                    counterGuard.WaitOne();
                    counter++;
                }
                finally
                {
                    counterGuard.ReleaseMutex();
                }
            }
            Console.WriteLine(counter);
            countdownEvent.Signal();
        }
    }
}
