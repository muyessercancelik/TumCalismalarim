﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Abstract.ICustomerCheckService;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth= new DateTime(1991,11,5), FirstName="Müyesser", LastName="Cançelik",
                                             Id=1234, NationalityId="46816966444"});

        }
    }
}