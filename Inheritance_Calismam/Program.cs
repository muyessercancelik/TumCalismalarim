using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Calismam
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Müyesser";
            musteri1.MusteriId = "212346";
            musteri1.MusteriNo = "54546525";
            musteri1.Soyadi = "Cançelik";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriId = "545123";
            musteri2.MusteriNo = "7876354";
            musteri2.SirketAdi = "Cançelikss";
            musteri2.VergiNo = "212345687981";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            Musteri[] musteris = new Musteri[]
            {
                new GercekMusteri {Adi="Emine", MusteriId="45445", MusteriNo="1212122", Soyadi="Can", TcNo="787984521485" },
                new GercekMusteri {Adi="Yahya", MusteriId="87815", MusteriNo="151515", Soyadi="Cançelikl", TcNo="7854518485"},
                new TuzelMusteri  {SirketAdi="Dekor Mobilya", MusteriId="5485152", VergiNo="21235422135", MusteriNo="1212122",}
            };

      

            foreach (var musteriler in musteris)
            {
                Console.WriteLine(musteriler.MusteriNo);
            }

            MusteriManager musteriManager = new MusteriManager();
            //musteriManager.Ekle(musteri1);
            //musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteris);


        }
    }
}
