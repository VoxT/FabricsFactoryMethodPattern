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
    public class Bank
    {
        [BsonElement("bank_name")]
        public string BankName { get; set; }

        [BsonElement("account_number")]
        public string AccountNumber { get; set; }

        public Bank() { }

        [BsonConstructor]
        public Bank(string bankName, string accountNumber)
        {
            BankName = bankName;
            AccountNumber = accountNumber;
        }
    }

}
