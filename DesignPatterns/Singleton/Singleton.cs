using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
       
        #region Second version - not thread-safe
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        #endregion
        
        #region Third version - thread-safe
        private static object lockThis = new object();
        //3. Simple Thread safe
        public static Singleton GetInstance_SimpleThreadSafe
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
        #endregion
        #region Third version - thread-safe
        private static object ObjlockThis = new object();
        //3. thread-safety using double-check locking
        public static Singleton GetInstance_DoubleCheckThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (ObjlockThis) // Multithreaded loak
                    {

                        if (instance == null)
                        {
                            instance = new Singleton();
                            Thread.MemoryBarrier();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion
        #region Fourth Version -Lazy Loading

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance { get { return lazy.Value; } }

        #endregion
    }
}
