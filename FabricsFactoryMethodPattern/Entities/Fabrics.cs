using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Fabrics : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public Fabrics()
        {
        }
    }
}
