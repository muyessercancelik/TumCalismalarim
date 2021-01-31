using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Müyesser";
            customer1.LastName = "Cançelik";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.City = "Ankara";

            Customer customer3 = new Customer() { Id = 3, FirstName = "Ahmet", LastName = "Cançelik", City = "İstanbul" };
            Customer customer4 = new Customer() { Id = 4, FirstName = "Emine", LastName = "Can", City = "Kilis" };

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine();
        }
    }
}
