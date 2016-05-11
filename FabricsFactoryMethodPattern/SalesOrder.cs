using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SalesOrder
    {
        private SalesOrderCollection salesOrderCollection;

        public SalesOrder()
        {
            salesOrderCollection = new SalesOrderCollection();
        }

        public void createSalesOrder(BsonDocument document)
        {
            salesOrderCollection.createDocument(document);
        }

        public List<BsonDocument> getAllSalesOrder()
        {
            return salesOrderCollection.selectAllDocument();
        }

        public BsonDocument getASalesOrder(ObjectId idSalesOrder)
        {
            return salesOrderCollection.selectADocument(idSalesOrder);
        }

        public Boolean deleteASalesOrder(ObjectId idSalesOrder)
        {
            return salesOrderCollection.deleteADocument(idSalesOrder);
        }

        public void UpdateASalesOrder(ObjectId idSalesOrder, BsonDocument document)
        {
            salesOrderCollection.UpdateADocument(idSalesOrder, document);

        }

    }
}
