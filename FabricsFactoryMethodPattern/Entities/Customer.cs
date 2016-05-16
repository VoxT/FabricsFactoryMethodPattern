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
    public class Customer : Person
    {
        [BsonElement("company_name")]
        public string CompanyName { get; set; }

        [BsonElement("taxt_number")]
        public string TaxNumber { get; set; }

        [BsonElement("debts")]
        public double Debts { get; set; }

        [BsonElement("bank")]
        public Bank Bank { get; set; }

        [BsonElement("goods_return")]
        public List<GoodsReturn> GoodsReturn { get; set; }

        [BsonElement("prices")]
        public List<Prices> Prices { get; set; }

        [BsonConstructor]
        public Customer()
        {
            GoodsReturn = new List<GoodsReturn>();
            Prices = new List<Prices>();
        }

        public Customer(string firstName, string lastName, string email, string address, List<Phone> cellPhone, List<Phone> deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = cellPhone;
            this.DeskPhones = deskPhone;
            this.Bank = bank;
        }

        public Customer(string firstName, string lastName, string email, string address, Phone cellPhone, Phone deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = new List<Phone> { cellPhone };
            this.DeskPhones = new List<Phone> { deskPhone };
            this.Bank = bank;
        }

    }
}
