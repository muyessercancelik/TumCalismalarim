using System;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Abstract;
using MernisServiceReference;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


                return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName,
                    customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
            }




            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper,
            //                                customer.LastName.ToUpper, customer.DateOfBirth.Year);


            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper,
            //                                customer.LastName.ToUpper, customer.DateOfBirth.Year);
        }

        public bool CheckIt(Customer customer)
        {
            throw new Exception("Login succesful!");
        }

        private object await(Task<TCKimlikNoDogrulaResponse> task)
        {
            throw new Exception("Kişi bulunmamaktadır.");
        }

    }
}
