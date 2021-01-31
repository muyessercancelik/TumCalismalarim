using System;

namespace MyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Add();
            product.Update();
            product.Delete();
        }
    }
    class Product
    {
        public void Add()
        {
            Console.WriteLine("Ürün Eklendi.");
        }
        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi.");
        }
        public void Delete()
        {
            Console.WriteLine("Ürün silindi.");
        }
    }
}
