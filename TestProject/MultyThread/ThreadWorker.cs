using System;
using System.Threading;

namespace TestProject.MultyThread
{
    class ThreadWorker
    {
        private Thread Thrd;
        private ThreadQueue<string> queue;
        private int index;
        private bool isActive = true;

        public bool Active
        {
            set
            {
                isActive = false;
                queue.Push(null);
            }
        }

        public ThreadWorker(ThreadQueue<string> queue,int index)
        {
            this.queue = queue;
            this.index = index;
            Thrd = new Thread(this.Run);
            Thrd.Start();
        }

        public void Run()
        {
            while (isActive)
            {
                string str = queue.Pop();
                if(str!=null)Console.WriteLine(str);
            }
        }

        public void Push()
        {
            Random rnd = new Random();
            int value = rnd.Next(5000);
            queue.Push("Thread " + index + " : " + value);
        }

    }
}
