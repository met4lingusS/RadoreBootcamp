using RadoreBootcamp2.SOLID.Iyi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Iyi.Classes
{
    public class DBLog : IDBLog
    {
        public void dbLog(string message)
        {
            Console.WriteLine($"{message} db'ye kaydedildi.");
        }
    }
}
