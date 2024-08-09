using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Kotu
{
    public class Logger
    {
        public DBLog dbLog;
        public XMLLog xmlLog;
        public JSONLog jsonLog;

        public Logger(DBLog dbLog, XMLLog xmlLog, JSONLog jsonLog)
        {
            this.dbLog = dbLog;
            this.xmlLog = xmlLog;
            this.jsonLog = jsonLog;
        }

        public void logKaydet(LogType type, string message)
        {
            switch (type)
            { 
                case LogType.xml:
                    xmlLog.xmlKayit(message);
                    break;
                case LogType.db:
                    dbLog.dbKayit(message); 
                    break;
                case LogType.json:
                    jsonLog.JSONYaz(message);
                    break;
            }

        }
    }
}
