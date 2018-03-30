using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    public  class Fruits
    {
        public  void GetFruitsColor()
        {
            Apple1 apple = new Orange1();
            var clor = apple.GetColor();
        }

    }

    public class Apple1
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }

    public class Orange1 : Apple1
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
