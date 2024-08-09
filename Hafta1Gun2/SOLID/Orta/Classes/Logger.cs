using RadoreBootcamp2.SOLID.Orta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Orta.Classes
{
    public class Logger : IDBLog, IJSONLog, IXMLLog, ICSVLog
    {
        // Bu yöntemi orta olarak kaydetmemdeki sebep, yeni uzantı eklemeyi kolaylaştırmış olsa da hem kayıt etme hem yönlendirme fonksiyonlarını gerçekleştirmesi SRP'ye aykırı olmasına sebep olması
        DBLog dblog;
        JSONLog jsonlog;
        XMLLog xmllog;
        CSVLog csvlog;
        public void dbLog(string message)
        {
            Console.WriteLine($"{message} db'ye kaydedildi.");
        }

        public void jsonLog(string message)
        {
            Console.WriteLine($"{message} json'a kaydedildi.");
        }

        public void xmlLog(string message)
        {
            Console.WriteLine($"{message} xml'e kaydedildi.");
        }

        public void csvLog(string message)
        {
            Console.WriteLine($"{message} csv'ye kaydedildi.");
        }

        public Logger(DBLog dblog, JSONLog jsonlog, XMLLog xmllog, CSVLog csvlog)
        {
            this.dblog = dblog;
            this.jsonlog = jsonlog;
            this.xmllog = xmllog;
            this.csvlog = csvlog;
        }   
        
        

    }

}
