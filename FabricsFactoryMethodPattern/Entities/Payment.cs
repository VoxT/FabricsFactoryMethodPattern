using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public enum PaymentType { revenues, expenditures }
public enum PaymentMethod { cash, transfer }

namespace FabricsFactoryMethodPattern.Entities
{
    public class Payment : Entity
    {
        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonElement("money")]
        public double Money { get; set; }

        [BsonElement("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [BsonElement("recipient_or_sender")]
        public string RecipientOrSender { get; set; }

        [BsonElement("bank_name")]
        public string BankName { get; set; }

        [BsonElement("account_number")]
        public string AccountNumber { get; set; }

        [BsonElement("payment_type")]
        public PaymentType PaymentType { get; set; }

        [BsonElement("employee_id")]
        public ObjectId EmployeeId { get; set; }

        [BsonElement("customer_id")]
        public ObjectId CustomerId { get; set; }

        [BsonElement("supplier_id")]
        public ObjectId SupplierId { get; set; }

        [BsonConstructor]
        public Payment()
        {
            this.Time = DateTime.Now;
        }

    }
}
