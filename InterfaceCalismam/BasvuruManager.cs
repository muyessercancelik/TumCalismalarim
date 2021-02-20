using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> basvurular)
        {
            foreach (var item in basvurular)
            {
                item.Hesapla();
            }
        }
        
    }
}
