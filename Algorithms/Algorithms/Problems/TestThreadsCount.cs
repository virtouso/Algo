using System;
using System.Threading;

namespace Algorithms.Problems
{
    public class TestThreadsCount
    {
        public void CountThreads()
        {
            int threadCount = 0;
            try
            {
                for (int i = 0; i < int.MaxValue; i ++)
                {
                    new Thread(() => Thread.Sleep(Timeout.Infinite)).Start();
                    threadCount ++;
                }
            }
            catch
            {
                Console.WriteLine(threadCount);
                Console.ReadKey(true);
            }
        }
    }
}