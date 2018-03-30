using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class MileageCalculator
    {
        IEnumerable<Car> _cars;
        public MileageCalculator(IEnumerable<Car> cars)
        {
            this._cars = cars;
        }

        public void CalculateMileage()
        {
            foreach (var car in _cars)
            {
                if (car.Name == "Audi")
                    Console.WriteLine("Mileage of the car {0} is {1}", car.Name, "10M");
                else if (car.Name == "Mercedes")
                    Console.WriteLine("Mileage of the car {0} is {1}", car.Name, "20M");
            }
        }
    }
}
