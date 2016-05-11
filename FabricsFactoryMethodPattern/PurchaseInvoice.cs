using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class PurchaseInvoice
    {
        private PurchaseInvoiceCollection purchaseInvoiceCollection;

        public PurchaseInvoice()
        {
            purchaseInvoiceCollection = new PurchaseInvoiceCollection();
        }

        public void createPurchaseInvoice(BsonDocument document)
        {
            purchaseInvoiceCollection.createDocument(document);
        }

        public List<BsonDocument> getAllPurchaseInvoice()
        {
            return purchaseInvoiceCollection.selectAllDocument();
        }

        public BsonDocument getAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.selectADocument(idPurchaseInvoice);
        }

        public Boolean deleteAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.deleteADocument(idPurchaseInvoice);
        }

        public void UpdateAPurchaseInvoice(ObjectId idPurchaseInvoice, BsonDocument document)
        {
            purchaseInvoiceCollection.UpdateADocument(idPurchaseInvoice, document);

        }

    }
}
