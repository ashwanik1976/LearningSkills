using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.Read();

        }
    }
}
