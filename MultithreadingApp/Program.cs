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
            try
            {
                //foreach (int x in Range(-10, 10))
                //{
                //    Console.WriteLine(x);
                //}
                ////Print data in Order from two diffrenet thread
                //ThreadSynchronizationByOrder thorder = new ThreadSynchronizationByOrder();
                //thorder.ThreadOrdering();

                //Race Condition
                RaceCondition raceCondition = new RaceCondition();
                raceCondition.GenerateRaceCondition();
                Console.WriteLine("End");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                throw ex;
            }
            Console.ReadLine();
        }

        static IEnumerable<int> Range(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                yield return i;
            }
            yield break;
        }
    }
}
