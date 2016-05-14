using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class FabricsRoll : Entity
    {
        public string Length { get; set; }
        public ObjectId FabricsId { get; set; }
        public ObjectId PlotsId { get; set; }
        public ObjectId PurchaseInvoiceId { get; set; }
        public ObjectId SalesInvoiceId { get; set; }

        public FabricsRoll()
        {
        }

    }
}
