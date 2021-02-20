using System;

namespace Calisma
{
    class UrunManager :Urun
    {
        public void Add(Urun urun)
        {
            Console.WriteLine("Ürün ekleme işlemi başarılı. " + urun.UrunAdi);
        }
    }
}
