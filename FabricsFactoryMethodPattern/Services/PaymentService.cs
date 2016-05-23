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

        public override void Create(Payment entity)
        {
            base.Create(entity);

            RecordService recordService = new RecordService();
            Record record = new Record
            {
                PaymentId = entity.Id,
                Monney = entity.Money,
                Note = "Record for Payment"
            };
            recordService.Create(record);

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

        public List<Payment> GetPaymentByDate(DateTime fromDate, DateTime toDate)
        { 
            var filterBuilder = Builders<Payment>.Filter;
            var filter = filterBuilder.Gt(p => p.Time, fromDate) & filterBuilder.Lt(p => p.Time, toDate);
            return this.Collection.Find(filter).ToList();
        }
    }
}
