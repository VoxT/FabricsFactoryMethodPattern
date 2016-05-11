using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class PurchaseOrder
    {
        private PurchaseOrderCollection purchaseOrderCollection;

        public PurchaseOrder()
        {
            purchaseOrderCollection = new PurchaseOrderCollection();
        }

        public void createPurchaseOrder(BsonDocument document)
        {
            purchaseOrderCollection.createDocument(document);
        }

        public List<BsonDocument> getAllPurchaseOrder()
        {
            return purchaseOrderCollection.selectAllDocument();
        }

        public BsonDocument getAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.selectADocument(idPurchaseOrder);
        }

        public Boolean deleteAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.deleteADocument(idPurchaseOrder);
        }

        public void UpdateAPurchaseOrder(ObjectId idPurchaseOrder, BsonDocument document)
        {
            purchaseOrderCollection.UpdateADocument(idPurchaseOrder, document);

        }

    }
}
