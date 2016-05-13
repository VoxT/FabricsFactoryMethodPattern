using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Price
    {
        public ObjectId FabricsColorId { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
    }

    public class CustomerPrice : Price
    {
        public ObjectId CustomerId { get; set; }
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

    public class SupplierPrice : Price
    {
        public ObjectId SupplierId { get; set; }
        private SupplierPriceCollection supplierPriceCollection;

        public SupplierPrice()
        {
            supplierPriceCollection = new SupplierPriceCollection();
        }

        public void CreateSupplierPrice(SupplierPrice document)
        {
            supplierPriceCollection.CreateDocument(document);
        }

        public List<SupplierPrice> GetAllSupplierPrice()
        {
            return supplierPriceCollection.SelectAllDocument();
        }

        public SupplierPrice GetASupplierPrice(ObjectId idSupplierPrice)
        {
            return supplierPriceCollection.SelectADocument(idSupplierPrice);
        }

        public Boolean DeleteASupplierPrice(ObjectId idSupplierPrice)
        {
            return supplierPriceCollection.DeleteADocument(idSupplierPrice);
        }

        public void UpdateASupplierPrice(ObjectId idSupplierPrice, SupplierPrice document)
        {
            supplierPriceCollection.UpdateADocument(idSupplierPrice, document);

        }

    }
}
