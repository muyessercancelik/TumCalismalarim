using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hepsalandı.");
        }
    }
}
