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
