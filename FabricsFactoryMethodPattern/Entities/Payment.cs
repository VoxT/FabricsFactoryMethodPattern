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

        public Payment()
        {
            this.Time = DateTime.Now;
        }

        [BsonConstructor]
        public Payment(ObjectId employeeId, PaymentType paymentType, string recipientOrSender, PaymentMethod paymentMethod, string bankName, string accountNumber, double money, ObjectId customerIdOrSupplierId)
        {
            this.PaymentType = paymentType;

            switch (paymentType)
            {
                // revenues payment (reciept)
                case PaymentType.revenues: this.CustomerId = customerIdOrSupplierId; break;

                // expenditures payment (pay)
                case PaymentType.expenditures: this.SupplierId = customerIdOrSupplierId; break;

                // ------
                default: break;
            }

            this.EmployeeId = employeeId;
            this.RecipientOrSender = recipientOrSender;
            this.PaymentMethod = paymentMethod;
            this.BankName = bankName;
            this.AccountNumber = accountNumber;
            this.Money = money;
        }

        [BsonConstructor]
        public Payment(ObjectId employeeId, PaymentType paymentType, string recipientOrSender, PaymentMethod paymentMethod, string bankName, string accountNumber, double money, ObjectId customerIdOrSupplierId, DateTime time)
        {
            this.PaymentType = paymentType;

            switch (paymentType)
            {
                // revenues payment (reciept)
                case PaymentType.revenues: this.CustomerId = customerIdOrSupplierId; break;

                // expenditures payment (pay)
                case PaymentType.expenditures: this.SupplierId = customerIdOrSupplierId; break;

                // ------
                default: break;
            }

            this.EmployeeId = employeeId;
            this.RecipientOrSender = recipientOrSender;
            this.PaymentMethod = paymentMethod;
            this.BankName = bankName;
            this.AccountNumber = accountNumber;
            this.Money = money;
            this.Time = time;
        }
    }
}
