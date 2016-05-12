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

        public void createSalesInvoice(SalesInvoice document)
        {
            salesInvoiceCollection.createDocument(document);
        }

        public List<SalesInvoice> getAllSalesInvoice()
        {
            return salesInvoiceCollection.selectAllDocument();
        }

        public SalesInvoice getASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.selectADocument(idSalesInvoice);
        }

        public Boolean deleteASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.deleteADocument(idSalesInvoice);
        }

        public void UpdateASalesInvoice(ObjectId idSalesInvoice, SalesInvoice document)
        {
            salesInvoiceCollection.UpdateADocument(idSalesInvoice, document);

        }

    }
}
