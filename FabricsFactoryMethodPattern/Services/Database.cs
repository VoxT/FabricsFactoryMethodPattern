using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace FabricsFactoryMethodPattern.Services
{
    public class Database
    {
        protected static IMongoDatabase database;

        protected IMongoDatabase DatabaseHandler { get { return database; } }

        public Database()
        {
            Connection con = new Connection();
            MongoClient connection = con.ConnectionHandler;

            database = connection.GetDatabase("fabrics");
        }
    }
}
