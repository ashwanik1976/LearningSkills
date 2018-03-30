using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    public class FruitsLSP
    {
        public void GetFruitsColor()
        {
            Fruit fruit = new Orange();
            //Console.WriteLine(fruit.GetColor());
            var color = fruit.GetColor().ToString();
            fruit = new Apple();
            //Console.WriteLine(fruit.GetColor());
            var color1 = fruit.GetColor().ToString();
        }
    }

    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
