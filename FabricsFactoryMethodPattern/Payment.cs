using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Payment
    {
         private PaymentCollection paymentCollection;

        public Payment()
        {
            paymentCollection = new PaymentCollection();
        }

        public void createPayment(BsonDocument document)
        {
            paymentCollection.createDocument(document);
        }

        public List<BsonDocument> getAllPayment()
        {
            return paymentCollection.selectAllDocument();
        }

        public BsonDocument getAPayment(ObjectId idPayment)
        {
            return paymentCollection.selectADocument(idPayment);
        }

        public Boolean deleteAPayment(ObjectId idPayment)
        {
            return paymentCollection.deleteADocument(idPayment);
        }

        public void UpdateAPayment(ObjectId idPayment, BsonDocument document)
        {
            paymentCollection.UpdateADocument(idPayment, document);

        }
    }
}
