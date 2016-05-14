using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public interface IEntity
    {
        ObjectId Id { get; }
    }
}
