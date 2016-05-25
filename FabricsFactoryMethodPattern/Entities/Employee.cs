using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Employee : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [BsonDateTimeOptions(DateOnly = true)]
        [BsonElement("birth_date")]
        public DateTime BirthDate { get; set; }

        [BsonElement("indentity_card_number")]
        public string IdentityCardNumber { get; set; }

        [BsonElement("salary")]
        public int Salary { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [BsonElement("join_date")]
        public DateTime JoinDate { get; set; }

        [BsonElement("degree")]
        public string Degree { get; set; }

        [BsonElement("shipper")]
        public Shipper Shipper { get; set; }

        [BsonElement("leave")]
        public List<Leave> Leave { get; set; }

        [BsonConstructor]
        public Employee()
        {
            this.JoinDate = DateTime.Now;
        }
        
    }
}
