using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SalesInvoice
    {
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
