using LoggingFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFormu.Classes
{
    public class CSVLog : ILog
    {
        public string Log(string message)
        {
            return $"{message}, csv'ye kaydedildi.";
        }
    }
}
