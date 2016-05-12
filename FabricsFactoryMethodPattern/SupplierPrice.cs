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

        public void createSupplierPrice(SupplierPrice document)
        {
            supplierPriceCollection.createDocument(document);
        }

        public List<SupplierPrice> getAllSupplierPrice()
        {
            return supplierPriceCollection.selectAllDocument();
        }

        public SupplierPrice getASupplierPrice(ObjectId idSupplierPrice)
        {
            return supplierPriceCollection.selectADocument(idSupplierPrice);
        }

        public Boolean deleteASupplierPrice(ObjectId idSupplierPrice)
        {
            return supplierPriceCollection.deleteADocument(idSupplierPrice);
        }

        public void UpdateASupplierPrice(ObjectId idSupplierPrice, SupplierPrice document)
        {
            supplierPriceCollection.UpdateADocument(idSupplierPrice, document);

        }

    }
}
