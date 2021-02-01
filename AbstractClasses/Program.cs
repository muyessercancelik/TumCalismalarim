using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet();
            aMevzuat.Degerlendir();
            
            
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir();//Bunu kullanan bütün sınıflar aynı koda sahip olmayabilir.
                                            //Beni kim kullanıyorsa kendine göre bu kodu yazsın.
        public void Kaydet()//Bunu kullanmak ise zorunlu.
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına göre değerlendirildi.");
        }
    }




    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");//İçinin boş olmaması gerekir.
        }
        public void Delete()
        {
            Console.WriteLine("Silindi.");
        }
    }
}
