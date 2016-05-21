using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using FabricsFactoryMethodPattern.Entities;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class FabricsRollService : EntityService<FabricsRoll>
    {
        public FabricsRollService()
        {
        }

        public List<FabricsRoll> GetFabricsRollForSalesInvoice(string salesInvoiceId)
        {
            var filter = Builders<FabricsRoll>.Filter.Eq(p => p.SalesInvoiceId, ObjectId.Parse(salesInvoiceId));
            var sort = Builders<FabricsRoll>.Sort.Ascending(p => p.FabricsColorId);
            var result = this.Collection.Find(filter).Sort(sort).ToList();

            return result;
        }

        public List<FabricsRoll> GetFabricsRollForPurchaseInvoice(string purchaseInvoiceId)
        {
            var filter = Builders<FabricsRoll>.Filter.Eq(p => p.PurchaseInvoiceId, ObjectId.Parse(purchaseInvoiceId));
            var sort = Builders<FabricsRoll>.Sort.Ascending(p => p.FabricsColorId);
            var result = this.Collection.Find(filter).Sort(sort).ToList();

            return result;
        }

    }
}
