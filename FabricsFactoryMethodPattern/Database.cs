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
    public abstract class Database<T>
    {
        protected MongoClient connect;
        protected IMongoDatabase database;
        protected IMongoCollection<T> collection;

        public Database()
        {
            connect = new MongoClient("mongodb://localhost:27017");
            database = connect.GetDatabase("fabrics");
        }

        public void createDocument(T document)
        {
            collection.InsertOne(document);
        }

        public List<T> selectAllDocument()
        {
            var filter = new BsonDocument();
            var document = collection.Find(filter).ToList();

            return document;
        }

        public T selectADocument(ObjectId idCustomer)
        {
            var filter = Builders<T>.Filter.Eq("_id", idCustomer);
            var document = collection.Find(filter).FirstOrDefault();

            return document;
        }

        public Boolean deleteADocument(ObjectId idCustomer)
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

    public class EmloyeeCollection : Database<Employee>
    {
        public EmloyeeCollection()
        {
            collection = database.GetCollection<Employee>("emloyee");
        }
    }

    public class ShipperCollection : Database<Shipper>
    {
        public ShipperCollection()
        {
            collection = database.GetCollection<Shipper>("shipper");
        }
    }

    public class LeaveCollection : Database<Leave>
    {
        public LeaveCollection()
        {
            collection = database.GetCollection<Leave>("leave");
        }
    }

    public class FabricsCollection : Database<Fabrics>
    {
        public FabricsCollection()
        {
            collection = database.GetCollection<Fabrics>("fabrics");
        }
    }

    public class FabricsColorCollection : Database<FabricsColor>
    {
        public FabricsColorCollection()
        {
            collection = database.GetCollection<FabricsColor>("fabricscolor");
        }
    }

    public class FabricsRollCollection : Database<FabricsRoll>
    {
        public FabricsRollCollection()
        {
            collection = database.GetCollection<FabricsRoll>("fabricsroll");
        }
    }

    public class FabricsPlotsCollection : Database<FabricsPlots>
    {
        public FabricsPlotsCollection()
        {
            collection = database.GetCollection<FabricsPlots>("fabricsplots");
        }
    }

    public class PaymentCollection : Database<Payment>
    {
        public PaymentCollection()
        {
            collection = database.GetCollection<Payment>("payment");
        }
    }

    public class RecordCollection : Database<Record>
    {
        public RecordCollection()
        {
            collection = database.GetCollection<Record>("record");
        }
    }

    public class SupplierCollection : Database<Supplier>
    {
        public SupplierCollection()
        {
            collection = database.GetCollection<Supplier>("supplier");
        }
    }

    public class SupplierCellPhoneCollection : Database<SupplierCellPhone>
    {
        public SupplierCellPhoneCollection()
        {
            collection = database.GetCollection<SupplierCellPhone>("suppliercellphone");
        }
    }

    public class SupplierDeskPhoneCollection : Database<SupplierDeskPhone>
    {
        public SupplierDeskPhoneCollection()
        {
            collection = database.GetCollection<SupplierDeskPhone>("supplierdeskphone");
        }
    }

    public class SupplierBankCollection : Database<SupplierBank>
    {
        public SupplierBankCollection()
        {
            collection = database.GetCollection<SupplierBank>("supplierbank");
        }
    }

    public class SupplierPriceCollection : Database<SupplierPrice>
    {
        public SupplierPriceCollection()
        {
            collection = database.GetCollection<SupplierPrice>("supplierprice");
        }
    }

    public class PurchaseGoodsCollection : Database<PurchaseGoods>
    {
        public PurchaseGoodsCollection()
        {
            collection = database.GetCollection<PurchaseGoods>("purchasegoods");
        }
    }

    public class SupplierGoodsReturnCollection : Database<SupplierGoodsReturn>
    {
        public SupplierGoodsReturnCollection()
        {
            collection = database.GetCollection<SupplierGoodsReturn>("suppliergoodsreturn");
        }
    }

    public class PurchaseOrderCollection : Database<PurchaseOrder>
    {
        public PurchaseOrderCollection()
        {
            collection = database.GetCollection<PurchaseOrder>("purchaseorder");
        }
    }

    public class PurchaseInvoiceCollection : Database<PurchaseInvoice>
    {
        public PurchaseInvoiceCollection()
        {
            collection = database.GetCollection<PurchaseInvoice>("purchaseinvoice");
        }
    }

    public class WareHouseCollection : Database<WareHouse>
    {
        public WareHouseCollection()
        {
            collection = database.GetCollection<WareHouse>("warehouse");
        }
    }

    public class CustomerCollection : Database<Customer>
    {
        public CustomerCollection()
        {
            collection = database.GetCollection<Customer>("customer");
        }
    }

    public class CustomerCellPhoneCollection : Database<CustomerCellPhone>
    {
        public CustomerCellPhoneCollection()
        {
            collection = database.GetCollection<CustomerCellPhone>("customercellphone");
        }
    }

    public class CustomerDeskPhoneCollection : Database<CustomerDeskPhone>
    {
        public CustomerDeskPhoneCollection()
        {
            collection = database.GetCollection<CustomerDeskPhone>("customerdeskphone");
        }
    }

    public class CustomerBankCollection : Database<CustomerBank>
    {
        public CustomerBankCollection()
        {
            collection = database.GetCollection<CustomerBank>("customerbank");
        }
    }

    public class CustomerPriceCollection : Database<CustomerPrice>
    {
        public CustomerPriceCollection()
        {
            collection = database.GetCollection<CustomerPrice>("customerprice");
        }
    }

    public class GoodsSoldCollection : Database<GoodsSold>
    {
        public GoodsSoldCollection()
        {
            collection = database.GetCollection<GoodsSold>("goodssold");
        }
    }

    public class SalesOrderCollection : Database<SalesOrder>
    {
        public SalesOrderCollection()
        {
            collection = database.GetCollection<SalesOrder>("salesorder");
        }
    }

    public class CustomerGoodsReturnCollection : Database<CustomerGoodsReturn>
    {
        public CustomerGoodsReturnCollection()
        {
            collection = database.GetCollection<CustomerGoodsReturn>("customergoodsreturn");
        }
    }

    public class SalesInvoiceCollection : Database<SalesInvoice>
    {
        public SalesInvoiceCollection()
        {
            collection = database.GetCollection<SalesInvoice>("salesinvoice");
        }
    }

    public class DeliveryCollection : Database<Delivery>
    {
        public DeliveryCollection()
        {
            collection = database.GetCollection<Delivery>("delivery");
        }
    }

    public class ExampleCollection : Database<Example>
    { 
        public ExampleCollection()
        {
            collection = database.GetCollection<Example>("example");
        }
    }

}
