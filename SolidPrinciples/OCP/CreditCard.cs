using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class CreditCard
    {
        public int CardType { get; set; }

        //public double GetDiscount(double monthlyCost)
        //{
        //    if (_CreditCardType == 1)
        //    {
        //        return monthlyCost * 0.05;
        //    }
        //    else
        //    {
        //        return monthlyCost * 0.01;
        //    }
        //}

        public virtual double GetDiscount(double monthlyCost)
        {
            return 0.0;
        }
    }
    /// <summary>
    /// Open closed code
    /// </summary>
    /// 
    interface ICreditCard
    {
       // int CreditCardType { get; set; }
        double GetDiscount(double monthlyCost);
    }
    public class BronzeCreditCard : ICreditCard
    {
       // public int CreditCardType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double GetDiscount(double monthlyCost)
        {
            return monthlyCost * 0.01;
        }
    }

    public class SilverCreditCard : ICreditCard
    {
        public double GetDiscount(double monthlyCost)
        {
            return monthlyCost * 0.02;
        }
    }

    public class GoldCreditCard : ICreditCard
    {
        public double GetDiscount(double monthlyCost)
        {
            return monthlyCost * 0.05;
        }
    }
}
