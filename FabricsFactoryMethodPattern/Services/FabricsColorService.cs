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
    public class FabricsColorService : EntityService<FabricsColor>
    {
        public FabricsColorService()
        {
        }

        public List<FabricsColor> GetFabricsColorForFabricsType(string fabricsTypeId)
        {
            var filter = Builders<FabricsColor>.Filter.Eq( p => p.FabricsId, ObjectId.Parse(fabricsTypeId));
            return this.Collection.Find(filter).ToList();
        }
    }
}
