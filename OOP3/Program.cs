using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////IhtıyacKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            //IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            ////KonutKrediManager konutKrediManager = new KonutKrediManager();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ////TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> loggerServices = new List<ILoggerService>() {smsLoggerService, databaseLoggerService };
            //basvuruManager.BasvuruYap(konutKrediManager, loggerServices);


            List<IKrediManager> krediler = new List<IKrediManager>() {esnafKrediManager,tasitKrediManager, ihtiyacKrediManager, konutKrediManager, tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesi(krediler, loggerServices);




        }
    }
}
