using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class PurchaseInvoice
    {
        private PurchaseInvoiceCollection purchaseInvoiceCollection;

        public PurchaseInvoice()
        {
            purchaseInvoiceCollection = new PurchaseInvoiceCollection();
        }

        public void createPurchaseInvoice(PurchaseInvoice document)
        {
            purchaseInvoiceCollection.createDocument(document);
        }

        public List<PurchaseInvoice> getAllPurchaseInvoice()
        {
            return purchaseInvoiceCollection.selectAllDocument();
        }

        public PurchaseInvoice getAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.selectADocument(idPurchaseInvoice);
        }

        public Boolean deleteAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.deleteADocument(idPurchaseInvoice);
        }

        public void UpdateAPurchaseInvoice(ObjectId idPurchaseInvoice, PurchaseInvoice document)
        {
            purchaseInvoiceCollection.UpdateADocument(idPurchaseInvoice, document);

        }

    }
}
