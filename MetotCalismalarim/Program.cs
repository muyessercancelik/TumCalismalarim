using System;

namespace MetotCalismalarim
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi="Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyat = 50;
            product2.Aciklama = "Adana Karpuzu";


            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
        }
    }
}
