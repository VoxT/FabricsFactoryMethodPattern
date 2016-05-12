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

        public void CreatePurchaseOrder(PurchaseOrder document)
        {
            purchaseOrderCollection.CreateDocument(document);
        }

        public List<PurchaseOrder> GetAllPurchaseOrder()
        {
            return purchaseOrderCollection.SelectAllDocument();
        }

        public PurchaseOrder GetAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.SelectADocument(idPurchaseOrder);
        }

        public Boolean DeleteAPurchaseOrder(ObjectId idPurchaseOrder)
        {
            return purchaseOrderCollection.DeleteADocument(idPurchaseOrder);
        }

        public void UpdateAPurchaseOrder(ObjectId idPurchaseOrder, PurchaseOrder document)
        {
            purchaseOrderCollection.UpdateADocument(idPurchaseOrder, document);

        }

    }
}
