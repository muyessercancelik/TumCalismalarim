using System;

namespace Inheritance//Kalıtım-- Miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "İsim";
            customer.City = "Şehir";

            Person[] persons = new Person[] { new Customer {FirstName="Yahya",LastName="Deneme",Id=5,City="GaziAntep" },
                                              new Student{FirstName="Hasan",LastName="Yıdız",Id=6, Department="IT" },
                                              new Person{FirstName="Emine",LastName="Can",Id=7, }
                                            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
