using System;

namespace Interfacees2
{
    class Program
    {
        //interfaceler new'lenemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager2();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            IPersonManager personManager = new ProjectManager();
            personManager.Add();

        }
    }
    class PersonManager
    {
        //implemented operation -- Tamamlanmış, içi doldurulmuş operasyon. Her yerdeortak demektir içindeki kodlar.
        public void Add()
        {
            Console.WriteLine("Eklendi.");
        }
    }
    class CustomerManager:PersonManager//Class larda :PersonManager inherits olur.
    {
        //Buradaki kod tüm personel için aynıdır.
    }

    interface IPersonManager//Interface üyeleri dışarıdan erişilebilir olmalıdır.O nedenle public yazmamanız gerekir. Defaultu public zaten.
    {                       //interface de ise evet imzam aynı ama Person için ekleme (Add) ayrı, personel için ekleme (add) olmalı.
        //unimplemented operation 
        public void Add();
        public void Update();
    }
    class CustomerManager2 : IPersonManager//interface lerde :IPersonManager implements olur.
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi.");//Buradaki kod ayrı- Müşteri ekleme kodları
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");//Buradaki kod ayrı -- Personel ekleme kodları
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }

    class ProjectManager:IPersonManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();

        }

        public void Add()
        {
            Console.WriteLine("Proje Çalıştı");
        }

        public void Update()
        {
            
        }
    }
}
