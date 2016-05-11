using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class CustomerDeskPhone
    {
        private CustomerDeskPhoneCollection customerDeskPhoneCollection;

        public CustomerDeskPhone()
        {
            customerDeskPhoneCollection = new CustomerDeskPhoneCollection();
        }

        public void createCustomerDeskPhone(BsonDocument document)
        {
            customerDeskPhoneCollection.createDocument(document);
        }

        public List<BsonDocument> getAllCustomerDeskPhone()
        {
            return customerDeskPhoneCollection.selectAllDocument();
        }

        public BsonDocument getACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.selectADocument(idCustomerDeskPhone);
        }

        public Boolean deleteACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.deleteADocument(idCustomerDeskPhone);
        }

        public void UpdateACustomerDeskPhone(ObjectId idCustomerDeskPhone, BsonDocument document)
        {
            customerDeskPhoneCollection.UpdateADocument(idCustomerDeskPhone, document);

        }

    }
}
