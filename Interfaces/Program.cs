using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[] {new SqlServerCustomerDal(),new OracleServerCustomerDal(), new MySqlServerCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Müyesser",
                LastName = "Cançelik",
                Address = "Bahçelievler"
            };
            Student student = new Student()
            {
                Id = 2,
                FirstName = "Mustafa",
                LastName = "Cançelik",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
            manager.Add(customer);

            manager.Add(new Customer { Id = 3, FirstName = "Ahmet", LastName = "Cançelik", Address = "Avcılar" });
        }
    }
    interface IPerson//Soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson//Somut nesne
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get ; set; }

        public string Address { get; set; }
    }

    class Student:IPerson//Somut nesne//Student:IPerson demek, IPerson için olanları sen de görebilirsin demektir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
   
    }


}
