using System;
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
         private RecordCollection recordCollection;

        public Record()
        {
            recordCollection = new RecordCollection();
        }

        public void createRecord(BsonDocument document)
        {
            recordCollection.createDocument(document);
        }

        public List<BsonDocument> getAllRecord()
        {
            return recordCollection.selectAllDocument();
        }

        public BsonDocument getARecord(ObjectId idRecord)
        {
            return recordCollection.selectADocument(idRecord);
        }

        public Boolean deleteARecord(ObjectId idRecord)
        {
            return recordCollection.deleteADocument(idRecord);
        }

        public void UpdateARecord(ObjectId idRecord, BsonDocument document)
        {
            recordCollection.UpdateADocument(idRecord, document);

        }
    }
}
