
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        void Save(Customer customer);
        bool CheckIfRealPerson(Customer customer);
    }
}
