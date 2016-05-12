using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class PurchaseOrder
    {
        private PurchaseOrderCollection purchaseOrderCollection;

        public PurchaseOrder()
        {
            purchaseOrderCollection = new PurchaseOrderCollection();
        }

        public void createPurchaseOrder(PurchaseOrder document)
        {
            purchaseOrderCollection.createDocument(document);
        }

        public List<PurchaseOrder> getAllPurchaseOrder()
        {
            return purchaseOrderCollection.selectAllDocument();
        }

        public PurchaseOrder getAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.selectADocument(idPurchaseOrder);
        }

        public Boolean deleteAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.deleteADocument(idPurchaseOrder);
        }

        public void UpdateAPurchaseOrder(ObjectId idPurchaseOrder, PurchaseOrder document)
        {
            purchaseOrderCollection.UpdateADocument(idPurchaseOrder, document);

        }

    }
}
