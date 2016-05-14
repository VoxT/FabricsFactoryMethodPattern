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
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public double Debts { get; set; }
        public CustomerBank Bank { get; set; }
        public List<CustomerGoodsReturn> GoodsReturn { get; set; }
        public List<CustomerPrice> Prices { get; set; }

        public Customer()
        {
        }

    }
}
