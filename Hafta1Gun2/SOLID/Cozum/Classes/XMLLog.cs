using RadoreBootcamp2.SOLID.Cozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Cozum.Classes
{
    public class XMLLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message} xml'e kaydedildi.");
        }
    }
}
