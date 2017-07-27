using System;
using TestProject.MultyThread;
using TestProject.PairsSums;

// 1.Надо сделать очередь с операциями push(T) и T pop(). Операции должны поддерживать обращение с разных потоков.
// Операция push всегда вставляет и выходит. Операция pop ждет пока не появится новый элемент.В качестве контейнера 
// внутри можно использовать только стандартную очередь (Queue) . 

// 2. Есть коллекция чисел и отдельное число Х.Надо вывести все пары чисел, которые в сумме равны заданному Х.

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to stop the MultyThread work.");
            TestThreadQueue testQueue = new TestThreadQueue(5);
            Console.ReadKey();
            TestFindPairSums testSumsPairs = new TestFindPairSums(100, 100, 150);
            Console.WriteLine("Sums pairs search is over, press any key to exit.");
            Console.ReadKey();
        }
    }
}