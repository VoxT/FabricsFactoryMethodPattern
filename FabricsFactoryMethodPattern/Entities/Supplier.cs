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
    public class Supplier : Person
    {
        [BsonElement("company_name")]
        public string CompanyName { get; set; }

        [BsonElement("taxt_number")]
        public string TaxNumber { get; set; }

        [BsonElement("debs")]
        public double Debts { get; set; }

        [BsonElement("bank")]
        public Bank Bank { get; set; }
        
        [BsonElement("goods_return")]
        public List<GoodsReturn> GoodsReturn { get; set; }

        [BsonElement("prices")]
        public List<Prices> Prices { get; set; }

        public Supplier()
        {
            GoodsReturn = new List<GoodsReturn>();
            Prices = new List<Prices>();
        }

        [BsonConstructor]
        public Supplier(string firstName, string lastName, string email, string address, List<CellPhone> cellPhone, List<DeskPhone> deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = cellPhone;
            this.DeskPhones = deskPhone;
            this.Bank = bank;
        }

        [BsonConstructor]
        public Supplier(string firstName, string lastName, string email, string address, CellPhone cellPhone, DeskPhone deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = new List<CellPhone> { cellPhone };
            this.DeskPhones = new List<DeskPhone> { deskPhone };
            this.Bank = bank;
        }

    }
}
