using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hepsalandı.");
        }
    }
}
