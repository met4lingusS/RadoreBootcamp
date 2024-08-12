using LoggingFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFormu.Classes
{
    internal class DBLog : ILog
    {
        public string Log(string message)
        {
            return $"{message}, db'ye kaydedildi.";
        }
    }
}
