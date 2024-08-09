using RadoreBootcamp2.SOLID.Iyi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Iyi.Classes
{
    public class XMLLog : IXMLLog
    {
        public void xmlLog(string message)
        {
            Console.WriteLine($"{message} xml'e kaydedildi.");
        }
    }
}
