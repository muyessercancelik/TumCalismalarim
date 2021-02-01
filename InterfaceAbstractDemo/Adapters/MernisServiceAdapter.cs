using InterfaceAbstractDemo.Abstract.ICustomerCheckService;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper,
                                            customer.LastName.ToUpper, customer.DateOfBirth.Year);


            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper,
            //                                customer.LastName.ToUpper, customer.DateOfBirth.Year);
        }
    }
}
