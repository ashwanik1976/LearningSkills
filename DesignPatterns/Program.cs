using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
           

            Hashtable ht = new Hashtable();
            ht.Add("name", "Ashwani Kumar");
            ht.Add("Salary", 10000);
            Dictionary<string,string> dictionary = new Dictionary<string,string> ();
            dictionary.Add("name", "Ashwani Kumar");
            //dictionary.Add("Salary", 10000);


            //RegularExpression
            string str = "test1\n   \ntest2\n   \ntest3\n   \n   \ntest4";
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }

            string[] result = Regex.Split(str, "\n\\s*");
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

            Task task = new Task(() => { Console.WriteLine("Hello"); });
            var tt = task.GetType();

                
            Thread thread = new Thread(new ThreadStart(() => { Console.WriteLine("Hello"); }));
            thread.Start();


            //overriding
            //BC b;
            //b = new BC(5,5);
            //b.Display();

           DC b = new DC(6,6);
            b.Display();

            //b = new TC();
            //b.Display();
            int x = new int();
            x = 20;
            int y = new int();
            y = x;
            y = 30;
            //Line3    
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            Console.ReadLine();
        }
    }

    class BC
    {
        public BC()
        {
            System.Console.WriteLine("empty");
        }
        public BC(int x, int y)
        {
            x = 10;
            y = 10;
            System.Console.WriteLine("base parameter");
        }
        
        public virtual void Display()
        {
            System.Console.WriteLine("BC::Display");
        }
    }

    class DC : BC
    {
        public DC(int x, int y) : base(x, y)
        {
            System.Console.WriteLine("DC Parameter");
        }
       
        public override void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }

    //class TC : DC
    //{
    //    public override void Display()
    //    {
    //        System.Console.WriteLine("TC::Display");
    //    }
    //}

    public abstract class Calculation
    {
        public abstract void Add();
        public virtual void Mul()
        { }
    }
    public class Calc : Calculation
    {
        public override void Add()
        { }
        public void Addtion()
        { }
    }
    public class Calc1 : Calc
    {
        public override void Add()
        { }
        public override void Mul()
        { }
    }
}
