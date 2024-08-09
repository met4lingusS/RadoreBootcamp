using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.SOLID.Iyi.Classes
{
    public class Logger
    {
        DBLog dblog;
        JSONLog jsonlog;
        XMLLog xmllog;
        CSVLog csvlog;

        public Logger(DBLog dblog, JSONLog jsonlog, XMLLog xmllog, CSVLog csvlog)
        {
            this.dblog = dblog;
            this.jsonlog = jsonlog;
            this.xmllog = xmllog;
            this.csvlog = csvlog;
        }

        public void toDB(string message)
        {
            dblog.dbLog(message);

        }
        public void toXML(string message)
        {
            xmllog.xmlLog(message);
        }

        public void toJSON(string message)
        {
            jsonlog.jsonLog(message);
        }

        public void toCSV(string message)
        {  
            csvlog.csvLog(message);
        }

    }
}
