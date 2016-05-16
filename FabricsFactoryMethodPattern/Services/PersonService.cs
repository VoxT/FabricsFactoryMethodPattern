using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using FabricsFactoryMethodPattern.Entities;

namespace FabricsFactoryMethodPattern.Services
{
    public abstract class PersonService<T> : EntityService<T>  where T : Person
    {
        public void AddCellPhone(string id, Phone phone)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<T>.Update.Push<Phone>(p => p.CellPhones, phone);
            var updateResult = this.Collection.UpdateOne(filter, update);

        }

        public void AddCellPhone(string id, List<Phone> phones)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            foreach (var value in phones)
            {
                var update = Builders<T>.Update.Push<Phone>(p => p.CellPhones, value);
                this.Collection.UpdateOne(filter, update);
            }

        }

        public void AddDeskPhone(string id, Phone phone)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<T>.Update.Push<Phone>(p => p.DeskPhones, phone);
            var updateResult = this.Collection.UpdateOne(filter, update);

        }

        public void AddDeskPhone(string id, List<Phone> phones)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            foreach (var value in phones)
            {
                var update = Builders<T>.Update.Push<Phone>(p => p.DeskPhones, value);
                this.Collection.UpdateOne(filter, update);
            }

        }
    }

    public abstract class BusinesspersonService<T> : PersonService<T> where T : Businessperson
    {
        public void AddFabricsPrice(string id, Prices price)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<T>.Update.Push<Prices>(p => p.Prices, price);
            var updateResult = this.Collection.UpdateOne(filter, update);
        }

        public void AddFabricsPrice(string id, List<Prices> prices)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            foreach (var value in prices)
            {
                var update = Builders<T>.Update.Push<Prices>(p => p.Prices, value);
                this.Collection.UpdateOne(filter, update);
            }
        }
    }
}
