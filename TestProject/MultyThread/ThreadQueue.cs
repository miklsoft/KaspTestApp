using System.Collections.Generic;
using System.Threading;

namespace TestProject.MultyThread
{
    class ThreadQueue<T>
    {
        private Queue<T> queue = new Queue<T>();

        public T Pop()
        {
            lock (queue)
            {
                while (queue.Count == 0)
                    Monitor.Wait(queue);
                return queue.Dequeue();
            }
        }

        public void Push(T data)
        {
            lock (queue)
            {
                queue.Enqueue(data);
                Monitor.Pulse(queue);
            }
        }

    }
}
