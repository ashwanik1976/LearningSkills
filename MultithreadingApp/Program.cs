using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print data in Order from two diffrenet thread
            ThreadSynchronizationByOrder thorder = new ThreadSynchronizationByOrder();
            thorder.ThreadOrdering();

            //Race Condition
            RaceCondition raceCondition = new RaceCondition();
            raceCondition.GenerateRaceCondition();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
