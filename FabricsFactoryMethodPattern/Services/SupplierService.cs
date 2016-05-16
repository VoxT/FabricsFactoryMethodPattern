using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class SupplierService : BusinesspersonService<Supplier>
    {
        public SupplierService()
        {
        }
        
    }
}
