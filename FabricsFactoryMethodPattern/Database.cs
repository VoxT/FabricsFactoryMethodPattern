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
        protected MongoClient connect;
        protected IMongoDatabase database;
        protected IMongoCollection<BsonDocument> collection;

        public Database()
        {
            connect = new MongoClient("mongodb://localhost:27017");
            database = connect.GetDatabase("fabrics");
        }

        public void createDocument(BsonDocument document)
        {
            collection.InsertOne(document);
        }

        public List<BsonDocument> selectAllDocument()
        {
            var filter = new BsonDocument();
            var document = collection.Find(filter).ToList();

            return document;
        }

        public BsonDocument selectADocument(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.Find(filter).FirstOrDefault();

            return document;
        }

        public Boolean deleteADocument(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.DeleteOne(filter);

            return true;
        }

        public void UpdateADocument(ObjectId idCustomer, BsonDocument document)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            foreach (var result in document)
            {
                var update = Builders<BsonDocument>.Update.Set(result.Name, result.Value);
                collection.UpdateOne(filter, update);
            }
        }

    }

    public class EmloyeeCollection : Database
    {
        public EmloyeeCollection()
        {
            collection = database.GetCollection<BsonDocument>("emloyee");
        }
    }

    public class ShipperCollection : Database
    {
        public ShipperCollection()
        {
            collection = database.GetCollection<BsonDocument>("shipper");
        }
    }

    public class LeaveCollection : Database
    {
        public LeaveCollection()
        {
            collection = database.GetCollection<BsonDocument>("leave");
        }
    }

    public class FabricsCollection : Database
    {
        public FabricsCollection()
        {
            collection = database.GetCollection<BsonDocument>("fabrics");
        }
    }

    public class FabricsColorCollection : Database
    {
        public FabricsColorCollection()
        {
            collection = database.GetCollection<BsonDocument>("fabricscolor");
        }
    }

    public class FabricsRollCollection : Database
    {
        public FabricsRollCollection()
        {
            collection = database.GetCollection<BsonDocument>("fabricsroll");
        }
    }

    public class FabricsPlotsCollection : Database
    {
        public FabricsPlotsCollection()
        {
            collection = database.GetCollection<BsonDocument>("fabricsplots");
        }
    }

    public class PaymentCollection : Database
    {
        public PaymentCollection()
        {
            collection = database.GetCollection<BsonDocument>("payment");
        }
    }

    public class RecordCollection : Database
    {
        public RecordCollection()
        {
            collection = database.GetCollection<BsonDocument>("record");
        }
    }

    public class SupplierCollection : Database
    {
        public SupplierCollection()
        {
            collection = database.GetCollection<BsonDocument>("supplier");
        }
    }

    public class SupplierCellPhoneCollection : Database
    {
        public SupplierCellPhoneCollection()
        {
            collection = database.GetCollection<BsonDocument>("suppliercellphone");
        }
    }

    public class SupplierDeskPhoneCollection : Database
    {
        public SupplierDeskPhoneCollection()
        {
            collection = database.GetCollection<BsonDocument>("supplierdeskphone");
        }
    }

    public class SupplierBankCollection : Database
    {
        public SupplierBankCollection()
        {
            collection = database.GetCollection<BsonDocument>("supplierbank");
        }
    }

    public class SupplierPriceCollection : Database
    {
        public SupplierPriceCollection()
        {
            collection = database.GetCollection<BsonDocument>("supplierprice");
        }
    }

    public class PurchaseGoodsCollection : Database
    {
        public PurchaseGoodsCollection()
        {
            collection = database.GetCollection<BsonDocument>("purchasegoods");
        }
    }

    public class SupplierGoodsReturnCollection : Database
    {
        public SupplierGoodsReturnCollection()
        {
            collection = database.GetCollection<BsonDocument>("suppliergoodsreturn");
        }
    }

    public class PurchaseOrderCollection : Database
    {
        public PurchaseOrderCollection()
        {
            collection = database.GetCollection<BsonDocument>("purchaseorder");
        }
    }

    public class PurchaseInvoiceCollection : Database
    {
        public PurchaseInvoiceCollection()
        {
            collection = database.GetCollection<BsonDocument>("purchaseinvoice");
        }
    }

    public class StoreCollection : Database
    {
        public StoreCollection()
        {
            collection = database.GetCollection<BsonDocument>("store");
        }
    }

    public class CustomerCollection : Database
    {
        public CustomerCollection()
        {
            collection = database.GetCollection<BsonDocument>("customer");
        }
    }

    public class CustomerCellPhoneCollection : Database
    {
        public CustomerCellPhoneCollection()
        {
            collection = database.GetCollection<BsonDocument>("customercellphone");
        }
    }

    public class CustomerDeskPhoneCollection : Database
    {
        public CustomerDeskPhoneCollection()
        {
            collection = database.GetCollection<BsonDocument>("customerdeskphone");
        }
    }

    public class CustomerBankCollection : Database
    {
        public CustomerBankCollection()
        {
            collection = database.GetCollection<BsonDocument>("customerbank");
        }
    }

    public class CustomerPriceCollection : Database
    {
        public CustomerPriceCollection()
        {
            collection = database.GetCollection<BsonDocument>("customerprice");
        }
    }

    public class GoodsSoldCollection : Database
    {
        public GoodsSoldCollection()
        {
            collection = database.GetCollection<BsonDocument>("goodssold");
        }
    }

    public class SalesOrderCollection : Database
    {
        public SalesOrderCollection()
        {
            collection = database.GetCollection<BsonDocument>("salesorder");
        }
    }

    public class CustomerGoodsReturnCollection : Database
    {
        public CustomerGoodsReturnCollection()
        {
            collection = database.GetCollection<BsonDocument>("customergoodsreturn");
        }
    }

    public class SalesInvoiceCollection : Database
    {
        public SalesInvoiceCollection()
        {
            collection = database.GetCollection<BsonDocument>("salesinvoice");
        }
    }

    public class DeliveryCollection : Database
    {
        public DeliveryCollection()
        {
            collection = database.GetCollection<BsonDocument>("delivery");
        }
    }

    public class ExampleCollection : Database
    {
        IMongoCollection<Example> collections;

        public ExampleCollection()
        {
            collections = database.GetCollection<Example>("example");
        }

        public void createDocument(Example document)
        {
            collections.InsertOne(document);
        }
    }

}
