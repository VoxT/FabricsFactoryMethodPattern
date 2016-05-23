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
    public class FabricsPlotsService : EntityService<FabricsPlots>
    {
        public FabricsPlotsService()
        {
        }

        public List<FabricsPlots> GetFabricsPlotsByDate(DateTime fromDate, DateTime toDate)
        {
            var filterBuilder = Builders<FabricsPlots>.Filter;
            var filter = filterBuilder.Gt(p => p.Time, fromDate) & filterBuilder.Lt(p => p.Time, toDate);
            return this.Collection.Find(filter).ToList();
        }
    }
}
