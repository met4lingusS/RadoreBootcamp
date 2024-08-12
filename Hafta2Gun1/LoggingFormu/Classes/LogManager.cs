using LoggingFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFormu.Classes
{
    public class LogManager
    {
        public ILog iLog;

        public LogManager(ILog iLog)
        {
            this.iLog = iLog;
        }

        public string LogKaydet(string message)
        {
            return iLog.Log(message);
        }
    }
}
