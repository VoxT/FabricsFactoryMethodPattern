﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Record
    {
        public ObjectId Id { get; private set; }
        public double Monney { get; set; }
        public DateTime Time { get; set; }
        public string Note { get; set; }
        public ObjectId PurchaseInvoiceId {get; set; }
        public ObjectId SalesInvoiceId { get; set; }
        public ObjectId PaymentId { get; set; }

        private RecordCollection recordCollection;

        public Record()
        {
            recordCollection = new RecordCollection();
        }

        public void CreateRecord(Record document)
        {
            recordCollection.CreateDocument(document);
        }

        public List<Record> GetAllRecord()
        {
            return recordCollection.SelectAllDocument();
        }

        public Record GetARecord(ObjectId idRecord)
        {
            return recordCollection.SelectADocument(idRecord);
        }

        public Boolean DeleteARecord(ObjectId idRecord)
        {
            return recordCollection.DeleteADocument(idRecord);
        }

        public void UpdateARecord(ObjectId idRecord, Record document)
        {
            recordCollection.UpdateADocument(idRecord, document);

        }
    }
}
