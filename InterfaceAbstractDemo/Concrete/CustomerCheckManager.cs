using InterfaceAbstractDemo.Entities;
using InterfaceAndAbstractDemo.Abstract;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}