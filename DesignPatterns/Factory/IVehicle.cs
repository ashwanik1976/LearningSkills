using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface IVehicle
    {
        void Drive(int miles);
        void Color(string color);
    }
}
