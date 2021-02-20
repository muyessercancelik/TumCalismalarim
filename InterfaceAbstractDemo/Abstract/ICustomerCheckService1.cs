using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService1
    {
        bool CheckIfRealPerson(Customer customer);
        void Save(Customer customer);
    }
}