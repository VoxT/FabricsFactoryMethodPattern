using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace FabricsFactoryMethodPattern
{
    public class Connection
    {
        private static MongoClient _connection;

        public Connection() { }

        public void CreateConnection()
        {
            _connection = new MongoClient("mongodb://localhost:27017");
        }

        public void CreateConnection(String connectionString)
        {
            _connection = new MongoClient(connectionString);
        }

        public MongoClient connection
        {
            get { return _connection;  }
        }

        public void Disconect()
        { 
            
        }
    }
}
