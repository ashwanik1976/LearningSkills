using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    public class RaceCondition
    {
        private static int counter;
        /// <summary>
        /// generate Race Condition
        /// </summary>
        public void GenerateRaceCondition()
        {
            Task.Factory.StartNew(PrintStar);
            Task.Factory.StartNew(PrintPlus);
            Console.ReadLine();
        }
        /// <summary>
        /// Avoid race Condition
        /// </summary>
        public void AvoidRaceCondition()
        {
            Task T1 = Task.Factory.StartNew(PrintStar);
            Task T2 = T1.ContinueWith(antacedent => PrintPlus());

            Task.WaitAll(new Task[] { T1, T2 });

            Console.WriteLine("Ending main thread");
        }
        private static void PrintStar()
        {
            for (counter = 0; counter < 5; counter++)
            {
                Console.Write(" * " + "\t");
            }
        }

        private static void PrintPlus()
        {
            for (counter = 0; counter < 5; counter++)
            {
                Console.Write(" + " + "\t");
            }
        }
       
    }
}
