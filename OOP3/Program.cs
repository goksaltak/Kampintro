using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService();

            List<IloggerService> loggers = new List<IloggerService> { new SmsLoggerService(), new FileLoggerService(),new DatabaseLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<IloggerService> {new DatabaseLoggerService(),new SmsLoggerService() });
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers );

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, ihtiyacKrediManager };
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}
}
