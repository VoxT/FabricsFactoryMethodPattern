using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Shipper
    {
        [BsonElement("driver_lincense_number")]
        public string DriverLincenseNumber { get; set; }

        [BsonConstructor]
        public Shipper()
        {
        }

        public Shipper(string driveLincenseNumber)
        {
            this.DriverLincenseNumber = driveLincenseNumber;
        }

    }
}
