using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class ServiceStationSRS
    {
        IGateUtility _gateUtility;

        public ServiceStationSRS(IGateUtility gateUtility)
        {
            this._gateUtility = gateUtility;
        }
        public void OpenForService()
        {
            _gateUtility.OpenGate();
        }

        public void DoService()
        {
            //Check if service station is opened and then
            //complete the vehicle service
        }

        public void CloseForDay()
        {
            _gateUtility.CloseGate();
        }
    }

    public interface IGateUtility
    {
        void OpenGate();
        void CloseGate();
    }
    public class ServiceStationUtility : IGateUtility
    {
        public void OpenGate()
        {
            //Open the shop if the time is later than 9 AM
        }

        public void CloseGate()
        {
            //Close the shop if the time has crossed 6PM
        }
    }

}
