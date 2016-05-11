using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerCustomerPrice
    {
        private CustomerPriceCollection customerPriceCollection;

        public CustomerCustomerPrice()
        {
            customerPriceCollection = new CustomerPriceCollection();
        }

        public void createCustomerPrice(BsonDocument document)
        {
            customerPriceCollection.createDocument(document);
        }

        public List<BsonDocument> getAllCustomerPrice()
        {
            return customerPriceCollection.selectAllDocument();
        }

        public BsonDocument getACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.selectADocument(idCustomerPrice);
        }

        public Boolean deleteACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.deleteADocument(idCustomerPrice);
        }

        public void UpdateACustomerPrice(ObjectId idCustomerPrice, BsonDocument document)
        {
            customerPriceCollection.UpdateADocument(idCustomerPrice, document);

        }

    }
}
