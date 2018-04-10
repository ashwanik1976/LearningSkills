using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingApp
{
    public class Deadlock
    {
        object locker1 = new object();
        object locker2 = new object();

        public void getDeadlock()
        {
            new Thread(() => 
            {
                lock (locker1)
                {
                    Thread.Sleep(1000);
                    lock (locker2); //dealock
                }
            }).Start();

            lock (locker2)
            {
                Thread.Sleep(1000);
                lock (locker1);    // Deadlock
            }
        }
    }
}
