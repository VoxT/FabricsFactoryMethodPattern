using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class FabricsColor : Entity
    {
        public string ColorName { get; set; }
        public ObjectId FabricsId { get; set; }

        public FabricsColor()
        {
        }

    }
}
