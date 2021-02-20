using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hepsalandı.");
        }
    }
}
