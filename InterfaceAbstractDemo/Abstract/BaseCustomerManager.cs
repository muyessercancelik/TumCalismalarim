using InterfaceAbstractDemo.Entities;
using System;


namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veri tabanına kayıt edildi : " + customer.FirstName);
        }
    }
}
