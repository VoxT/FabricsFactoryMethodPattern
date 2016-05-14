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
    public abstract class Bank
    {
        [BsonElement("bank_name")]
        public string BankName { get; set; }

        [BsonElement("account_number")]
        public string AccountNumber { get; set; }
    }

    public class CustomerBank : Bank
    {
        public CustomerBank()
        {
        }

    }

    public class SupplierBank : Bank
    {
        public SupplierBank()
        {
        }

    }
}
