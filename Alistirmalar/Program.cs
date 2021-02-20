using System;

namespace Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dersler = new string[]
            {
            "Matematik","Türkçe","Yeni Ders Geometri","Coğrafya","Biyoloji","Yeni bir ders daha"
            };
            Console.WriteLine("----------------FOR------------------");
            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }
            Console.WriteLine("----------------FOREACH------------------");
            foreach (string ders in dersler)
            {
                Console.WriteLine(ders);
            }

            Kitap kitap1 = new Kitap();
            kitap1.KitapAdi = "Aşkın Gözyaşları";
            kitap1.YazarAdi = "Sinan Yağmur";
            kitap1.StokAdedi = 150;
            kitap1.Fiyat = 25;

            Kitap kitap2 = new Kitap();
            kitap2.KitapAdi = "Aşk";
            kitap2.YazarAdi = "Elif Şafak";
            kitap2.StokAdedi = 200;
            kitap2.Fiyat = 30;

            Kitap[] kitaps = new Kitap[] { kitap1, kitap2 };

            foreach (Kitap kitap in kitaps)
            {
                Console.WriteLine(kitap.KitapAdi + " " + kitap.YazarAdi + " " + kitap.StokAdedi + " " + kitap.Fiyat);
            }

        }
    }

    class Kitap
    {
        public string YazarAdi { get; set; }
        public string KitapAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
    }
}
