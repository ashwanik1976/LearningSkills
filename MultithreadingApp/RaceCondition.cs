using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    /// <summary>
    /// A race condition occurs when two or more threads are able to access shared data 
    /// and they try to change it at the same time.
    /// 
    ///  mutual exclusion is a property of concurrency control, 
    ///  which is instituted for the purpose of preventing race conditions; 
    ///  it is the requirement that one thread of execution never enter its critical section at the same time 
    ///  that another concurrent thread of execution enters its own critical section.

    /// </summary>


    public class RaceCondition
    {
        private static int counter;
        private static void PrintStar()
        {
            try
            {
                for (counter = 0; counter < 5; counter++)
                {
                    int i = 10, j = 0;
                    int k = 10 / j;
                    Console.Write(" * " + "\t");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void PrintPlus()
        {
            for (counter = 0; counter < 5; counter++)
            {
                Console.Write(" + " + "\t");
            }
        }
        /// <summary>
        /// generate Race Condition
        /// </summary>
        ///
        public void GenerateRaceCondition()
        {
            
            //try
            //{
                //Thread T1 = new Thread(PrintStar);
                //T1.Start();

                //Thread T2 = new Thread(PrintPlus);
                //T2.Start();


                Task T1 = Task.Factory.StartNew(PrintStar);
                Task T2 = Task.Factory.StartNew(PrintPlus);
            //Task t = Task.Factory.StartNew(() => {
            //    try
            //    {
            //        Console.WriteLine("Digging is in progress");
            //        throw new Exception("Tool is crashed");
            //    }
            //    catch (Exception ae)
            //    {
            //        Console.WriteLine("Stop the work and notify others :" + ae.Message);
            //    }
            //});
           // Task.WaitAll(new Task[] { T1, T2 });
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            //Console.ReadLine();
        }
        /// <summary>
        /// Avoid race Condition
        /// 1. Synchronization using Thread.Join()
        /// 2. Synchronization using Task.ContinueWith
        /// 3. Synchronization using Lock
        /// 4. Synchronization using Monitor Enter – Monitor Exit
        /// 
        /// </summary>
        public void AvoidRaceCondition()
        {
            //With threading

            //var T1 = new Thread(PrintStar);
            //T1.Start();
            //T1.Join();

            //var T2 = new Thread(PrintPlus);
            //T2.Start();
            //T2.Join();

            //With Task
            Task T1 = Task.Factory.StartNew(PrintStar);

            //TPL continue method is useful to start a task after another one completes its execution
            Task T2 = T1.ContinueWith(antacedent => PrintPlus());

            Task.WaitAll(new Task[] { T1, T2 });

            Console.WriteLine("Ending main thread");
        }
    }
}
