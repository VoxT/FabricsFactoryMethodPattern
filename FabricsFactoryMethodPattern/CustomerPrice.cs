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

        public void CreateCustomerPrice(CustomerPrice document)
        {
            customerPriceCollection.CreateDocument(document);
        }

        public List<CustomerPrice> GetAllCustomerPrice()
        {
            return customerPriceCollection.SelectAllDocument();
        }

        public CustomerPrice GetACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.SelectADocument(idCustomerPrice);
        }

        public Boolean DeleteACustomerPrice(ObjectId idCustomerPrice)
        {
            return customerPriceCollection.DeleteADocument(idCustomerPrice);
        }

        public void UpdateACustomerPrice(ObjectId idCustomerPrice, CustomerPrice document)
        {
            customerPriceCollection.UpdateADocument(idCustomerPrice, document);

        }

    }
}
