using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SupplierPrice
    {
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
