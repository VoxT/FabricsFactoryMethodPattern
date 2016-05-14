using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class FabricsPlots : Entity
    {
        public string Time { get; set; }

        public FabricsPlots()
        {
        }

    }
}
