using RadoreBootcamp2.SOLID.Cozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Cozum.Classes
{
    public class Logger
    {
        public ILog iLog;

        // Constructorında ILog interfacei implemente edilmiş her objenin nesnesini oluşturur
        // Constructor Injection + Dependency Inversion = Dependency Injection
        public Logger(ILog iLog) 
        {
            this.iLog = iLog;
        }

        public void LogKaydet(string message)
        {
            iLog.Log(message);
        }

    }
}
