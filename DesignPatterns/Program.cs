using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using DesignPatterns.Factory;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //VehicleFactory factory = new ConcreateVehicleFactory();

            //IVehicle vehicle = factory.GetVehicle("Bike");
            //vehicle.Drive(20);
            //Console.Read();

            var aa=Singleton.Singleton.GetInstance;
            var bb = Singleton.Singleton.GetInstance;

            if (aa==bb)
            {
                Console.Write("sgdhd");
            }
           

            Hashtable ht = new Hashtable();
            ht.Add("name", "Ashwani Kumar");
            ht.Add("Salary", 10000);
            Dictionary<string,string> dictionary = new Dictionary<string,string> ();
            dictionary.Add("name", "Ashwani Kumar");
            //dictionary.Add("Salary", 10000);


            //RegularExpression
            string str = "test1\n   \ntest2\n   \ntest3\n   \n   \ntest4";
            string[] result = Regex.Split(str, "\n\\s*");
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

            Task task = new Task(() => { Console.WriteLine("Hello"); });
            var tt = task.GetType();

                
            Thread thread = new Thread(new ThreadStart(() => { Console.WriteLine("Hello"); }));
            thread.Start();


            //overriding
            BC b;
            b = new BC();
            b.Display();

            b = new DC();
            b.Display();

            b = new TC();
            b.Display();


            Console.ReadLine();
        }
    }

    class BC
    {
        public virtual void Display()
        {
            System.Console.WriteLine("BC::Display");
        }
    }

    class DC : BC
    {
        public override void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }

    class TC : DC
    {
        public override void Display()
        {
            System.Console.WriteLine("TC::Display");
        }
    }
}
