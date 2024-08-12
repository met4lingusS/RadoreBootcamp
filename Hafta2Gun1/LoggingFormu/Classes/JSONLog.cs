using LoggingFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFormu.Classes
{
    public class JSONLog : ILog
    {
        public string Log(string message)
        {
            return $"{message}, json'a kaydedildi.";
        }
    }
}
