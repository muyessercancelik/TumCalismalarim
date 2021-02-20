using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunId = 1;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunId = 2;

            //Urun[] urunler = new Urun[] { urun1,urun2};

            
            //foreach (Urun urun in urunler)
            //{
            //    Console.WriteLine(urun.UrunAdi);
            //    Console.WriteLine(urun.UrunId);
            //    Console.WriteLine("-----------------------");
            //}

            UrunManager urunManager = new UrunManager();
            urunManager.Add(urun1);
            urunManager.Add(urun2);
        }
    }
}
