using System;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper,
                                            customer.LastName.ToUpper, customer.DateOfBirth.Year);


            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper,
            //                                customer.LastName.ToUpper, customer.DateOfBirth.Year);
        }
    }
}
