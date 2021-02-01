using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo.Abstract.ICustomerCheckService
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
       
    }
}
