using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP
{
    public class Shoping
    {

    }

    public interface IOrder1
    {
        void Purchase();
        void ProcessCreditCard();
    }

    public class OnlineOrder1 : IOrder1
    {
        public void Purchase()
        {
            //Do purchase
        }

        public void ProcessCreditCard()
        {
            //process through credit card
        }
    }

    public class InpersionOrder1 : IOrder1
    {
        public void Purchase()
        {
            //Do purchase
        }

        public void ProcessCreditCard()
        {
            //Not required for inperson purchase
            throw new NotImplementedException();
        }
    }
}
