using System;
using IronPython.Hosting;

namespace Denemeler
{
    class Program//:Metotlarim
    {
        static void Main(string[] args)
        {

            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);































            //var a = 1;
            //var b = 2;
            //var ad = "Deneme";
            //int c= a + b;
            //string d = ad;
            //Console.WriteLine(c+" "+ d);

            //object sayi1 = 1;
            //object sayi2 = 2;
            //int toplam = (int) sayi2 + (int) sayi1;
            //Console.WriteLine(toplam);

            //Console.WriteLine("Bir sayı giriniz: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //int topla = a + b;
            //Console.WriteLine(topla);

            //if (a>b)
            //{
            //    Console.WriteLine(a + " Sayısı "+ b+ " sayısından büyüktür." );
            //}
            //else if (a<b)
            //{
            //    Console.WriteLine(b + " Sayısı " + a + " sayısından büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz iki sayı birbirine eşittir.");
            //}


            //if (a%4==0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı, 4 ile tam bölünür.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı 4 ile tam bölünmez.");
            //}

            //if (a>=0 && a<=100)
            //{
            //    Console.WriteLine(a+ " 0 ile 100 arasındadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Değildir.");
            //}


 

            //Console.WriteLine("Bir sayı giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for (int  i= 0; i <a; i++)
            //{
            //    Console.WriteLine(metin);
            //}

          

            //for (int i = 1; i > 0; i++)
            //{
            //    int sevapPoint=1;
            //    sevapPoint = i;
            //    Console.WriteLine(sevapPoint);
            //}

            //int sevapPoint2 = 0;

            //for (int i = 1; i >0; i++)
            //{
            //    Console.WriteLine(sevapPoint2++);
            //}

            /*var a = 10;
            var b = "merhaba";
            string c = b;

            Console.WriteLine(a+b+c);*/

            //------------------------------------------------------------------

            /*bool userName = true;
            bool password = false;
            if (userName ==true)
            {
                Console.WriteLine("Kullanıcı adı Doğru, Şifre giriniz: ");

                if (password == true)
                {
                    Console.WriteLine("Ana Sayfaya Hoşgeldiniz! ");
                }
                else
                {
                    Console.WriteLine("Şifreniz yanlış, lütfen terar deneyiniz.");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adını hatalı girdiniz, tekrar deneyiniz.");
            }*/

            //------------------------------------------------------------------

            /*double dolarDun = 7.6;
            double dolarBugun = 7.6;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düşmüş");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar artmış");
            }
            else
            {
                Console.WriteLine("Dolar sabit kalmış");
            }*/


            //------------------------------------------------------------------

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /* string a = "Sepete Ekle Butonu";
             foreach (var item in a)
             {
                 Console.WriteLine(a);
             }
            */

            //------------------------------------------------------------------

            /*String[] diziOrnegi = new String[] {"0. indis","1. indis","2. indis","3. indis","4. indis"};
            for (int i = 0; i < diziOrnegi.Length; i++)
            {
                Console.WriteLine(diziOrnegi[i]);
            }*/

            /*String[,] diziOrnegi2 = new String[,] { 
                { "0. indis", "1. Değer" },
                { "1. indis", "2. Değer" },
                { "2. indis", "3. Değer" },
                { "3. indis", "4. Değer" },
                { "4. indis", "5. Değer" } };

            foreach (var item in diziOrnegi2)
            {
                Console.WriteLine(item);
            }*/


            //------------------------------------------------------------------


            /*Ders ders1 = new Ders();
            ders1.DersAdi = "Matematik";
            ders1.DersId = 101;
            ders1.Egitmen = "Adem Özyavaş";
            ders1.TamamlanmaOrani = 80;

            
            Ders ders2 = new Ders();
            ders2.DersAdi = "Türkçe";
            ders2.DersId = 105;
            ders2.Egitmen = "Emine Cançelik";
            ders2.TamamlanmaOrani = 70;

            Ders[] dersler = new Ders[]{ders1,ders2};

            foreach (var ders in dersler)
            {
                Console.WriteLine(ders.DersAdi);
                Console.WriteLine(ders.DersId);
                Console.WriteLine(ders.Egitmen);
                Console.WriteLine(ders.TamamlanmaOrani);
                Console.WriteLine("-----------------------------------------------------------");
            }*/

            /*int uzunkenar, kısakenar;
            Console.WriteLine("Uzun Kenarı Giriniz: ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kısa Kenarı Giriniz: ");
            kısakenar=Convert.ToInt32(Console.ReadLine());
            Alan(uzunkenar,kısakenar);


            int toplamaSonucu = Toplam();
            Console.WriteLine(toplamaSonucu);

            int carpimSonucu = Carp(5, 8);
            Console.WriteLine(carpimSonucu);*/
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
             _array = new T[0];
        }
 
       
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
   

        public int Count
        {
            get { return _array.Length; }
        }

    }










    /*class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string Egitmen { get; set; }
        public int TamamlanmaOrani { get; set; }
    }*/

    /*class Metotlarim
    {
        public static void Alan(int uk, int kk)
        {
            int sonuc = uk * kk;
            Console.WriteLine("Alan sonucu: "+sonuc);
        }

        public static int Toplam()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            return a + b; 
        }
        public static int Carp(int a, int b)
        {

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }
    }*/
}
