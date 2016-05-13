using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Order
    {
        public ObjectId Id { get; private set; }
        public bool Status{ get; set; }
        public DateTime Time { get; set; }
    }

    public class PurchaseOrder : Order
    {
        public ObjectId EmployeeId { get; set; }

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

    public class SalesOrder : Order
    {
        public ObjectId CustomerId { get; set; }

        private SalesOrderCollection salesOrderCollection;

        public SalesOrder()
        {
            salesOrderCollection = new SalesOrderCollection();
        }

        public void CreateSalesOrder(SalesOrder document)
        {
            salesOrderCollection.CreateDocument(document);
        }

        public List<SalesOrder> GetAllSalesOrder()
        {
            return salesOrderCollection.SelectAllDocument();
        }

        public SalesOrder GetASalesOrder(ObjectId idSalesOrder)
        {
            return salesOrderCollection.SelectADocument(idSalesOrder);
        }

        public Boolean DeleteASalesOrder(ObjectId idSalesOrder)
        {
            return salesOrderCollection.DeleteADocument(idSalesOrder);
        }

        public void UpdateASalesOrder(ObjectId idSalesOrder, SalesOrder document)
        {
            salesOrderCollection.UpdateADocument(idSalesOrder, document);

        }

    }
}
