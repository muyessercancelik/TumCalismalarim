﻿using InterfaceAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}