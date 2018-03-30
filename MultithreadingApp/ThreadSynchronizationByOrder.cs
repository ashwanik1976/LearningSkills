using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    public class ThreadSynchronizationByOrder
    {
        static AutoResetEvent auto1 = new AutoResetEvent(false);
        static AutoResetEvent auto2 = new AutoResetEvent(false);

        public void ThreadOrdering()
        {
            var t1 = Task.Factory.StartNew(() => PrintOddNumbers());
            var t2 = Task.Factory.StartNew(() => PrintEvenNumbers());

            Task.WaitAny(t1, t2);
        }
        
        private static void PrintOddNumbers()
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
                auto2.Set();
                auto1.WaitOne();
            }
        }

        private static void PrintEvenNumbers()
        {
            int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14 };

            foreach (var item in arr)
            {
                auto2.WaitOne();
                Console.WriteLine(item);
                auto1.Set();
            }
            auto1.Set();
        }

    }
}
