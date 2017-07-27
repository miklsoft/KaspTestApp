using System;
using System.Collections.Generic;
using System.Threading;

namespace TestProject.MultyThread
{
    class TestThreadQueue
    {
        public TestThreadQueue(int count)
        {
            ThreadQueue<string> queue = new ThreadQueue<string>();
            List<ThreadWorker> threads = new List<ThreadWorker>();

            for (int i = 1; i <= count; i++)
                threads.Add(new ThreadWorker(queue, i));

            while (Console.KeyAvailable == false)
                foreach (ThreadWorker thread in threads)
                {
                    thread.Push();
                    Thread.Sleep(500);
                }

            foreach (ThreadWorker thread in threads)
                thread.Active = false;
        }
    }
}
