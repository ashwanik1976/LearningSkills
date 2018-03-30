using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        //1.Static instance of class
        private static Singleton instance = null;
        //2. private constructor
        private Singleton()
        {
        }

        private static object lockThis = new object();
        //3. static read only propery
        public static Singleton GetInstance
        {
            get
            {
                lock (lockThis) // Multithreaded loak
                {

                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
        

    }
}
