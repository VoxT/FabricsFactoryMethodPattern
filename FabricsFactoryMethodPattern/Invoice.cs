using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Invoice
    {
        public ObjectId Id { get; private set; }
        public DateTime Time { get; set; }
        public string PaymentMethod { get; set; }
        public short Discount { get; set; }
    }

    public class PurchaseInvoice : Invoice
    {
        public ObjectId WareHouseId { get; set; }
        public ObjectId SupplierId { get; set; }
        public ObjectId PurchaseInvoiceId { get; set; }
        public ObjectId EmployeeId { get; set; }

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

    public class SalesInvoice : Invoice
    {
        public ObjectId CustomerId { get; set; }
        public ObjectId SalesOrderId { get; set; }
        public ObjectId EmployeeId { get; set; }

        private SalesInvoiceCollection salesInvoiceCollection;

        public SalesInvoice()
        {
            salesInvoiceCollection = new SalesInvoiceCollection();
        }

        public void CreateSalesInvoice(SalesInvoice document)
        {
            salesInvoiceCollection.CreateDocument(document);
        }

        public List<SalesInvoice> GetAllSalesInvoice()
        {
            return salesInvoiceCollection.SelectAllDocument();
        }

        public SalesInvoice GetASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.SelectADocument(idSalesInvoice);
        }

        public Boolean DeleteASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.DeleteADocument(idSalesInvoice);
        }

        public void UpdateASalesInvoice(ObjectId idSalesInvoice, SalesInvoice document)
        {
            salesInvoiceCollection.UpdateADocument(idSalesInvoice, document);

        }

    }
}
