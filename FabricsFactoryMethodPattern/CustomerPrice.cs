using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerPrice
    {
        private CustomerPriceCollection customerPriceCollection;

        public CustomerPrice()
        {
            customerPriceCollection = new CustomerPriceCollection();
        }

        public void createCustomerPrice(CustomerPrice document)
        {
            customerPriceCollection.createDocument(document);
        }

        public List<CustomerPrice> getAllCustomerPrice()
        {
            return customerPriceCollection.selectAllDocument();
        }

        public CustomerPrice getACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.selectADocument(idCustomerPrice);
        }

        public Boolean deleteACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.deleteADocument(idCustomerPrice);
        }

        public void UpdateACustomerPrice(ObjectId idCustomerPrice, CustomerPrice document)
        {
            customerPriceCollection.UpdateADocument(idCustomerPrice, document);

        }

    }
}
