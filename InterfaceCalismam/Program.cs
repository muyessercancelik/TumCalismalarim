using System;
using System.Collections.Generic;

namespace InterfaceCalismam
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService>() {new SmsLoggerService(), new DataBaseLoggerService() });

            List<IKrediManager> basvurular = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(basvurular);


            //ihtiyacKrediManager.Hesapla();
            //tasitKrediManager.Hesapla();
            //konutKrediManager.Hesapla();

        }
    }
}
