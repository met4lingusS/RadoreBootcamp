using LoggingFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFormu.Classes
{
    public class LogManagerFactory
    {
        public ILog LogNesnesiOlustur(string logName)
        {
            var newInstance = Assembly.GetAssembly(typeof(ILog)).CreateInstance("LoggingFormu.Classes." + logName);
            return (ILog)newInstance;
        }
    }
}
