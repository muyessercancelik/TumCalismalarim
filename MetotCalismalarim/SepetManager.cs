using System;
using System.Collections.Generic;
using System.Text;

namespace MetotCalismalarim
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi: "+ product.Adi);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Fiyat);
            Console.WriteLine(product.Aciklama);
            Console.WriteLine("-------------------------------------");
        }
    }
}
