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
    public abstract class Database
    {
        protected static IMongoDatabase database;

        public Database()
        {
            MongoClient connection = (new Connection()).connection;

            database = connection.GetDatabase("fabrics");
        }
    }

    abstract class Collection<T> : Database
    {
        protected IMongoCollection<T> collection;

        public Collection()
        {
            MongoClient connection = (new Connection()).connection;
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

    class EmloyeeCollection : Collection<Employee>
    {
        public EmloyeeCollection()
        {
            collection = database.GetCollection<Employee>("emloyee");
        }
    }

    class ShipperCollection : Collection<Shipper>
    {
        public ShipperCollection()
        {
            collection = database.GetCollection<Shipper>("shipper");
        }
    }

    class LeaveCollection : Collection<Leave>
    {
        public LeaveCollection()
        {
            collection = database.GetCollection<Leave>("leave");
        }
    }

    class FabricsCollection : Collection<Fabrics>
    {
        public FabricsCollection()
        {
            collection = database.GetCollection<Fabrics>("fabrics");
        }
    }

    class FabricsColorCollection : Collection<FabricsColor>
    {
        public FabricsColorCollection()
        {
            collection = database.GetCollection<FabricsColor>("fabricscolor");
        }
    }

    class FabricsRollCollection : Collection<FabricsRoll>
    {
        public FabricsRollCollection()
        {
            collection = database.GetCollection<FabricsRoll>("fabricsroll");
        }
    }

    class FabricsPlotsCollection : Collection<FabricsPlots>
    {
        public FabricsPlotsCollection()
        {
            collection = database.GetCollection<FabricsPlots>("fabricsplots");
        }
    }

    class PaymentCollection : Collection<Payment>
    {
        public PaymentCollection()
        {
            collection = database.GetCollection<Payment>("payment");
        }
    }

    class RecordCollection : Collection<Record>
    {
        public RecordCollection()
        {
            collection = database.GetCollection<Record>("record");
        }
    }

    class SupplierCollection : Collection<Supplier>
    {
        public SupplierCollection()
        {
            collection = database.GetCollection<Supplier>("supplier");
        }
    }

    class SupplierCellPhoneCollection : Collection<SupplierCellPhone>
    {
        public SupplierCellPhoneCollection()
        {
            collection = database.GetCollection<SupplierCellPhone>("suppliercellphone");
        }
    }

    class SupplierDeskPhoneCollection : Collection<SupplierDeskPhone>
    {
        public SupplierDeskPhoneCollection()
        {
            collection = database.GetCollection<SupplierDeskPhone>("supplierdeskphone");
        }
    }

    class SupplierBankCollection : Collection<SupplierBank>
    {
        public SupplierBankCollection()
        {
            collection = database.GetCollection<SupplierBank>("supplierbank");
        }
    }

    class SupplierPriceCollection : Collection<SupplierPrice>
    {
        public SupplierPriceCollection()
        {
            collection = database.GetCollection<SupplierPrice>("supplierprice");
        }
    }

    class PurchaseGoodsCollection : Collection<PurchaseGoods>
    {
        public PurchaseGoodsCollection()
        {
            collection = database.GetCollection<PurchaseGoods>("purchasegoods");
        }
    }

    class SupplierGoodsReturnCollection : Collection<SupplierGoodsReturn>
    {
        public SupplierGoodsReturnCollection()
        {
            collection = database.GetCollection<SupplierGoodsReturn>("suppliergoodsreturn");
        }
    }

    class PurchaseOrderCollection : Collection<PurchaseOrder>
    {
        public PurchaseOrderCollection()
        {
            collection = database.GetCollection<PurchaseOrder>("purchaseorder");
        }
    }

    class PurchaseInvoiceCollection : Collection<PurchaseInvoice>
    {
        public PurchaseInvoiceCollection()
        {
            collection = database.GetCollection<PurchaseInvoice>("purchaseinvoice");
        }
    }

    class WareHouseCollection : Collection<WareHouse>
    {
        public WareHouseCollection()
        {
            collection = database.GetCollection<WareHouse>("warehouse");
        }
    }

    class CustomerCollection : Collection<Customer>
    {
        public CustomerCollection()
        {
            collection = database.GetCollection<Customer>("customer");
        }
    }

    class CustomerCellPhoneCollection : Collection<CustomerCellPhone>
    {
        public CustomerCellPhoneCollection()
        {
            collection = database.GetCollection<CustomerCellPhone>("customercellphone");
        }
    }

    class CustomerDeskPhoneCollection : Collection<CustomerDeskPhone>
    {
        public CustomerDeskPhoneCollection()
        {
            collection = database.GetCollection<CustomerDeskPhone>("customerdeskphone");
        }
    }

    class CustomerBankCollection : Collection<CustomerBank>
    {
        public CustomerBankCollection()
        {
            collection = database.GetCollection<CustomerBank>("customerbank");
        }
    }

    class CustomerPriceCollection : Collection<CustomerPrice>
    {
        public CustomerPriceCollection()
        {
            collection = database.GetCollection<CustomerPrice>("customerprice");
        }
    }

    class GoodsSoldCollection : Collection<GoodsSold>
    {
        public GoodsSoldCollection()
        {
            collection = database.GetCollection<GoodsSold>("goodssold");
        }
    }

    class SalesOrderCollection : Collection<SalesOrder>
    {
        public SalesOrderCollection()
        {
            collection = database.GetCollection<SalesOrder>("salesorder");
        }
    }

    class CustomerGoodsReturnCollection : Collection<CustomerGoodsReturn>
    {
        public CustomerGoodsReturnCollection()
        {
            collection = database.GetCollection<CustomerGoodsReturn>("customergoodsreturn");
        }
    }

    class SalesInvoiceCollection : Collection<SalesInvoice>
    {
        public SalesInvoiceCollection()
        {
            collection = database.GetCollection<SalesInvoice>("salesinvoice");
        }
    }

    class DeliveryCollection : Collection<Delivery>
    {
        public DeliveryCollection()
        {
            collection = database.GetCollection<Delivery>("delivery");
        }
    }

    class ExampleCollection : Collection<Example>
    { 
        public ExampleCollection()
        {
            collection = database.GetCollection<Example>("example");
        }
    }

}
