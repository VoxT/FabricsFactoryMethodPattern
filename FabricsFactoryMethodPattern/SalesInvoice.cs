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

        public void createSalesInvoice(BsonDocument document)
        {
            salesInvoiceCollection.createDocument(document);
        }

        public List<BsonDocument> getAllSalesInvoice()
        {
            return salesInvoiceCollection.selectAllDocument();
        }

        public BsonDocument getASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.selectADocument(idSalesInvoice);
        }

        public Boolean deleteASalesInvoice(ObjectId idSalesInvoice)
        {
            return salesInvoiceCollection.deleteADocument(idSalesInvoice);
        }

        public void UpdateASalesInvoice(ObjectId idSalesInvoice, BsonDocument document)
        {
            salesInvoiceCollection.UpdateADocument(idSalesInvoice, document);

        }

    }
}
