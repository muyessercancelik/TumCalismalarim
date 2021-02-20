using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class EsnafKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi hesaplandı.");
        }
    }
}
