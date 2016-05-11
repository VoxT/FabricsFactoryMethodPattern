using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class CustomerCellPhone
    {
        private CustomerCellPhoneCollection customerCellPhoneCollection;

        public CustomerCellPhone()
        {
            customerCellPhoneCollection = new CustomerCellPhoneCollection();
        }

        public void createCustomerCellPhone(BsonDocument document)
        {
            customerCellPhoneCollection.createDocument(document);
        }

        public List<BsonDocument> getAllCustomerCellPhone()
        {
            return customerCellPhoneCollection.selectAllDocument();
        }

        public BsonDocument getACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.selectADocument(idCustomerCellPhone);
        }

        public Boolean deleteACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.deleteADocument(idCustomerCellPhone);
        }

        public void UpdateACustomerCellPhone(ObjectId idCustomerCellPhone, BsonDocument document)
        {
            customerCellPhoneCollection.UpdateADocument(idCustomerCellPhone, document);

        }

    }
}
