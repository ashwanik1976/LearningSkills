﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class ServiceStation
    {
        public void OpenGate()
        {
            //Open the gate if the time is later than 9 AM
        }

        public void DoService(Vehicle vehicle)
        {
            //Check if service station is opened and then
            //complete the vehicle service
        }

        public void CloseGate()
        {
            //Close the gate if the time has crossed 6PM
        }
    }
}
