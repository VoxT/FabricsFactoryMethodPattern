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
    using Entities;

    public class EmployeeService : PersonService<Employee>
    {
        public EmployeeService()
        {
        }

        public void AddLeave(string id, Leave leave)
        {
            var filter = Builders<Employee>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<Employee>.Update.Push<Leave>(p => p.Leave, leave);
            var updateResult = this.Collection.UpdateOne(filter, update);
        }

        public void AddLeave(string id, List<Leave> leave)
        {
            var filter = Builders<Employee>.Filter.Eq(p => p.Id, ObjectId.Parse(id));

            foreach (var value in leave)
            {
                var update = Builders<Employee>.Update.Push<Leave>(p => p.Leave, value);
                this.Collection.UpdateOne(filter, update);
            }
        }

        public List<Employee> GetShipper()
        {
            var filter = Builders<Employee>.Filter.Where(p => p.DriverLincenseNumber != null);
            return this.Collection.Find(filter).ToList();
        }

    }
}
