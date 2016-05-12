using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;

namespace FabricsFactoryMethodPattern
{
    abstract class Database<T>
    {
        protected static IMongoDatabase database;
        protected IMongoCollection<T> collection;

        public Database()
        {
            MongoClient connection = (new Connection()).connection;

            database = connection.GetDatabase("fabrics");
        }

        public void CreateDocument(T document)
        {
            collection.InsertOne(document);
        }

        public List<T> SelectAllDocument()
        {
            var filter = new BsonDocument();
            var document = collection.Find(filter).ToList();

            return document;
        }

        public T SelectADocument(ObjectId idCustomer)
        {
            var filter = Builders<T>.Filter.Eq("_id", idCustomer);
            var document = collection.Find(filter).FirstOrDefault();

            return document;
        }

        public Boolean DeleteADocument(ObjectId idCustomer)
        {
            var filter = Builders<T>.Filter.Eq("_id", idCustomer);
            var document = collection.DeleteOne(filter);

            return true;
        }

        public void UpdateADocument(ObjectId idCustomer, T document)
        {
            var filter = Builders<T>.Filter.Eq("_id", idCustomer);
            foreach (var result in document.ToBsonDocument<T>())
            {
                var update = Builders<T>.Update.Set(result.Name, result.Value);
                collection.UpdateOne(filter, update);
            }
        }

        public void UpdateADocument(ObjectId idCustomer, BsonDocument document)
        {
            var filter = Builders<T>.Filter.Eq("_id", idCustomer);
            foreach (var result in document)
            {
                var update = Builders<T>.Update.Set(result.Name, result.Value);
                collection.UpdateOne(filter, update);
            }
        }

    }

    class EmloyeeCollection : Database<Employee>
    {
        public EmloyeeCollection()
        {
            collection = database.GetCollection<Employee>("emloyee");
        }
    }

    class ShipperCollection : Database<Shipper>
    {
        public ShipperCollection()
        {
            collection = database.GetCollection<Shipper>("shipper");
        }
    }

    class LeaveCollection : Database<Leave>
    {
        public LeaveCollection()
        {
            collection = database.GetCollection<Leave>("leave");
        }
    }

    class FabricsCollection : Database<Fabrics>
    {
        public FabricsCollection()
        {
            collection = database.GetCollection<Fabrics>("fabrics");
        }
    }

    class FabricsColorCollection : Database<FabricsColor>
    {
        public FabricsColorCollection()
        {
            collection = database.GetCollection<FabricsColor>("fabricscolor");
        }
    }

    class FabricsRollCollection : Database<FabricsRoll>
    {
        public FabricsRollCollection()
        {
            collection = database.GetCollection<FabricsRoll>("fabricsroll");
        }
    }

    class FabricsPlotsCollection : Database<FabricsPlots>
    {
        public FabricsPlotsCollection()
        {
            collection = database.GetCollection<FabricsPlots>("fabricsplots");
        }
    }

    class PaymentCollection : Database<Payment>
    {
        public PaymentCollection()
        {
            collection = database.GetCollection<Payment>("payment");
        }
    }

    class RecordCollection : Database<Record>
    {
        public RecordCollection()
        {
            collection = database.GetCollection<Record>("record");
        }
    }

    class SupplierCollection : Database<Supplier>
    {
        public SupplierCollection()
        {
            collection = database.GetCollection<Supplier>("supplier");
        }
    }

    class SupplierCellPhoneCollection : Database<SupplierCellPhone>
    {
        public SupplierCellPhoneCollection()
        {
            collection = database.GetCollection<SupplierCellPhone>("suppliercellphone");
        }
    }

    class SupplierDeskPhoneCollection : Database<SupplierDeskPhone>
    {
        public SupplierDeskPhoneCollection()
        {
            collection = database.GetCollection<SupplierDeskPhone>("supplierdeskphone");
        }
    }

    class SupplierBankCollection : Database<SupplierBank>
    {
        public SupplierBankCollection()
        {
            collection = database.GetCollection<SupplierBank>("supplierbank");
        }
    }

    class SupplierPriceCollection : Database<SupplierPrice>
    {
        public SupplierPriceCollection()
        {
            collection = database.GetCollection<SupplierPrice>("supplierprice");
        }
    }

    class PurchaseGoodsCollection : Database<PurchaseGoods>
    {
        public PurchaseGoodsCollection()
        {
            collection = database.GetCollection<PurchaseGoods>("purchasegoods");
        }
    }

    class SupplierGoodsReturnCollection : Database<SupplierGoodsReturn>
    {
        public SupplierGoodsReturnCollection()
        {
            collection = database.GetCollection<SupplierGoodsReturn>("suppliergoodsreturn");
        }
    }

    class PurchaseOrderCollection : Database<PurchaseOrder>
    {
        public PurchaseOrderCollection()
        {
            collection = database.GetCollection<PurchaseOrder>("purchaseorder");
        }
    }

    class PurchaseInvoiceCollection : Database<PurchaseInvoice>
    {
        public PurchaseInvoiceCollection()
        {
            collection = database.GetCollection<PurchaseInvoice>("purchaseinvoice");
        }
    }

    class WareHouseCollection : Database<WareHouse>
    {
        public WareHouseCollection()
        {
            collection = database.GetCollection<WareHouse>("warehouse");
        }
    }

    class CustomerCollection : Database<Customer>
    {
        public CustomerCollection()
        {
            collection = database.GetCollection<Customer>("customer");
        }
    }

    class CustomerCellPhoneCollection : Database<CustomerCellPhone>
    {
        public CustomerCellPhoneCollection()
        {
            collection = database.GetCollection<CustomerCellPhone>("customercellphone");
        }
    }

    class CustomerDeskPhoneCollection : Database<CustomerDeskPhone>
    {
        public CustomerDeskPhoneCollection()
        {
            collection = database.GetCollection<CustomerDeskPhone>("customerdeskphone");
        }
    }

    class CustomerBankCollection : Database<CustomerBank>
    {
        public CustomerBankCollection()
        {
            collection = database.GetCollection<CustomerBank>("customerbank");
        }
    }

    class CustomerPriceCollection : Database<CustomerPrice>
    {
        public CustomerPriceCollection()
        {
            collection = database.GetCollection<CustomerPrice>("customerprice");
        }
    }

    class GoodsSoldCollection : Database<GoodsSold>
    {
        public GoodsSoldCollection()
        {
            collection = database.GetCollection<GoodsSold>("goodssold");
        }
    }

    class SalesOrderCollection : Database<SalesOrder>
    {
        public SalesOrderCollection()
        {
            collection = database.GetCollection<SalesOrder>("salesorder");
        }
    }

    class CustomerGoodsReturnCollection : Database<CustomerGoodsReturn>
    {
        public CustomerGoodsReturnCollection()
        {
            collection = database.GetCollection<CustomerGoodsReturn>("customergoodsreturn");
        }
    }

    class SalesInvoiceCollection : Database<SalesInvoice>
    {
        public SalesInvoiceCollection()
        {
            collection = database.GetCollection<SalesInvoice>("salesinvoice");
        }
    }

    class DeliveryCollection : Database<Delivery>
    {
        public DeliveryCollection()
        {
            collection = database.GetCollection<Delivery>("delivery");
        }
    }

    class ExampleCollection : Database<Example>
    { 
        public ExampleCollection()
        {
            collection = database.GetCollection<Example>("example");
        }
    }

}
