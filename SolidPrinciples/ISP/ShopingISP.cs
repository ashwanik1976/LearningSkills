using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP
{
    class ShopingISP
    {
    }
    public interface IOrder
    {
        void Purchase();
    }

    public interface IOnlineOrder
    {
        void ProcessCreditCard();
    }
    public class OnlineOrder : IOrder, IOnlineOrder
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

    public class InpersionOrder : IOrder
    {
        public void Purchase()
        {
            //Do purchase
        }
    }
}
