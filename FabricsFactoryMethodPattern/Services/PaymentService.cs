using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class PaymentService : EntityService<Payment>
    {
        public PaymentService()
        {
        }

        public List<Payment> GetPaymentForSupplier(string id)
        {
            var filter = Builders<Payment>.Filter.Eq(p => p.SupplierId, ObjectId.Parse(id));
            return this.Collection.Find(filter).ToList();
        }

        public List<Payment> GetPaymentForCustomer(string id)
        {
            var filter = Builders<Payment>.Filter.Eq(p => p.CustomerId, ObjectId.Parse(id));
            return this.Collection.Find(filter).ToList();
        }
             
    }
}
