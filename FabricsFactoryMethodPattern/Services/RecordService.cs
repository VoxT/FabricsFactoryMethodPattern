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
    public class RecordService : EntityService<Record>
    {
        public RecordService()
        {
        }



        public List<Record> GetRecordByDate(DateTime fromDate, DateTime toDate)
        {
            var filterBuilder = Builders<Record>.Filter;
            var filter = filterBuilder.Gt(p => p.Time, fromDate) & filterBuilder.Lt(p => p.Time, toDate);
            return this.Collection.Find(filter).ToList();
        }
    }
}
