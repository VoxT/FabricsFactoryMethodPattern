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

        public void CreatePurchaseInvoice(PurchaseInvoice document)
        {
            purchaseInvoiceCollection.CreateDocument(document);
        }

        public List<PurchaseInvoice> GetAllPurchaseInvoice()
        {
            return purchaseInvoiceCollection.SelectAllDocument();
        }

        public PurchaseInvoice GetAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.SelectADocument(idPurchaseInvoice);
        }

        public Boolean DeleteAPurchaseInvoice(ObjectId idPurchaseInvoice)
        {
            return purchaseInvoiceCollection.DeleteADocument(idPurchaseInvoice);
        }

        public void UpdateAPurchaseInvoice(ObjectId idPurchaseInvoice, PurchaseInvoice document)
        {
            purchaseInvoiceCollection.UpdateADocument(idPurchaseInvoice, document);

        }

    }
}
