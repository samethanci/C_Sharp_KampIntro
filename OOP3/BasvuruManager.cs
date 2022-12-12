using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        //public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        //{
        //    krediManager.Hesapla();
        //    loggerService.Log();
        //}

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesi(List<IKrediManager> krediler, List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
