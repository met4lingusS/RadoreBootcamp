


/*
using RadoreBootcamp2.SOLID.Kotu;


XMLLog xMLLog = new XMLLog();
DBLog dblog = new DBLog();
JSONLog jsonlog = new JSONLog();
Logger logger = new Logger(dblog, xMLLog, jsonlog);
logger.logKaydet(LogType.xml, "303 no'lu hata kodu oluştu.");
logger.logKaydet(LogType.db, "303 no'lu hata kodu oluştu.");
logger.logKaydet(LogType.json, "303 no'lu hata kodu oluştu.");
*/


/*

using RadoreBootcamp2.SOLID.Orta.Classes;

DBLog dbLog = new DBLog();
JSONLog jsonLog = new JSONLog();
XMLLog xmlLog = new XMLLog();
CSVLog csvLog = new CSVLog();
Logger logger = new Logger(dbLog, jsonLog, xmlLog, csvLog);
logger.dbLog("303 nolu hata oluştu,");
logger.xmlLog("404 nolu hata oluştu,");
logger.jsonLog("027 nolu kayıt işlendi,");
logger.csvLog("027 nolu kayıt işlendi,");
*/

using RadoreBootcamp2.SOLID.Iyi.Classes;


CSVLog csvLog = new CSVLog();
DBLog dbLog = new DBLog();
JSONLog jsonLog = new JSONLog();
XMLLog xmlLog = new XMLLog();
Logger logger = new Logger(dbLog, jsonLog, xmlLog, csvLog);

logger.toDB("303 nolu hata oluştu,");
logger.toJSON("027 nolu kayıt işlendi,");
logger.toXML("404 nolu hata oluştu,");
logger.toCSV("027 nolu kayıt işlendi,");


