using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> _instance = new Lazy<Log>(() => new Log());
        private Log()
        {
        }
        public static Log GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }
        public void LogException(string message)
        {
            //string name = "Ashwani Kumar";
        }
    }
}
