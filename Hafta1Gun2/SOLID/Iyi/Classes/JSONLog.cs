using RadoreBootcamp2.SOLID.Iyi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Iyi.Classes
{
    public class JSONLog : IJSONLog
    {
        public void jsonLog(string message)
        {
            Console.WriteLine($"{message} json'a kaydedildi.");
        }
    }
}
