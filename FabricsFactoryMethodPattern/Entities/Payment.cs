using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Payment : Entity
    {
        public DateTime Time { get; set; }
        public double Money { get; set; }
        public string PaymentMethod { get; set; }
        public string RecipientOrSender { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string Method { get; set; }
        public ObjectId EmployeeId { get; set; }
        public ObjectId CustomerId { get; set; }
        public ObjectId SupplierId { get; set; }

        public Payment()
        {
        }

    }
}
