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
    public abstract class Phone
    {
    }

    public class CellPhone : Phone
    {

        [BsonElement("cellphone_number")]
        public string CellPhoneNumber { get; set; }

        [BsonConstructor]
        public CellPhone(string cellPhoneNumber)
        {
            this.CellPhoneNumber = cellPhoneNumber;
        }

    }

    public class DeskPhone : Phone
    {

        [BsonElement("deskphone_number")]
        public string DeskPhoneNumber { get; set; }

        [BsonConstructor]
        public DeskPhone(string deskPhone)
        {
            this.DeskPhoneNumber = deskPhone;
        }

    }

}
