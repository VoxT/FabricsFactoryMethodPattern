using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Person : Entity
    {

        [BsonElement("cell_phone")]
        public List<Phone> CellPhones { get; set; }

        [BsonElement("desk_phone")]
        public List<Phone> DeskPhones { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        public Person()
        {
            this.CellPhones = new List<Phone>();
            this.DeskPhones = new List<Phone>();
        }
    }

    public abstract class Businessperson : Person
    {

        [BsonElement("company_name")]
        public string CompanyName { get; set; }

        [BsonElement("tax_number")]
        public string TaxNumber { get; set; }

        [BsonElement("debts")]
        public double Debts { get; set; }

        [BsonElement("bank")]
        public Bank Bank { get; set; }

        [BsonElement("goods_return")]
        public List<GoodsReturn> GoodsReturn { get; set; }

        [BsonElement("prices")]
        public List<Prices> Prices { get; set; }

        public Businessperson()
        {
            this.GoodsReturn = new List<GoodsReturn>();
            this.Prices = new List<Prices>();
        }

    }
}
