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

        public SupplierBank Bank { get; set; }

        public List<SupplierGoodsReturn> GoodsReturn { get; set; }
        public List<SupplierPrice> Prices { get; set; }

        public Supplier()
        {
            GoodsReturn = new List<SupplierGoodsReturn>();
            Prices = new List<SupplierPrice>();
        }

    }
}
