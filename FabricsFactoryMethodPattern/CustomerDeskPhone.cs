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

        public void createCustomerDeskPhone(CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.createDocument(document);
        }

        public List<CustomerDeskPhone> getAllCustomerDeskPhone()
        {
            return customerDeskPhoneCollection.selectAllDocument();
        }

        public CustomerDeskPhone getACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.selectADocument(idCustomerDeskPhone);
        }

        public Boolean deleteACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.deleteADocument(idCustomerDeskPhone);
        }

        public void UpdateACustomerDeskPhone(ObjectId idCustomerDeskPhone, CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.UpdateADocument(idCustomerDeskPhone, document);

        }

    }
}
