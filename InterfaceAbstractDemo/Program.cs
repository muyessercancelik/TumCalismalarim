using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Abstract;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth= new DateTime(1991,11,5), FirstName="Müyesser", LastName="Cançelik",
                                              NationalityId="46816966444"});


            //BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            //customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "" });
            //Console.ReadLine();

        }
    }
}
