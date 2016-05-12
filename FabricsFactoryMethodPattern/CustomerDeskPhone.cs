using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerDeskPhone
    {
        private CustomerDeskPhoneCollection customerDeskPhoneCollection;

        public CustomerDeskPhone()
        {
            customerDeskPhoneCollection = new CustomerDeskPhoneCollection();
        }

        public void CreateCustomerDeskPhone(CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.CreateDocument(document);
        }

        public List<CustomerDeskPhone> GetAllCustomerDeskPhone()
        {
            return customerDeskPhoneCollection.SelectAllDocument();
        }

        public CustomerDeskPhone GetACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.SelectADocument(idCustomerDeskPhone);
        }

        public Boolean DeleteACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.DeleteADocument(idCustomerDeskPhone);
        }

        public void UpdateACustomerDeskPhone(ObjectId idCustomerDeskPhone, CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.UpdateADocument(idCustomerDeskPhone, document);
        }

    }
}
