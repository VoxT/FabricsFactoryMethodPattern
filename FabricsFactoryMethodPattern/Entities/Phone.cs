using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Phone
    {
    }

    public abstract class CellPhone : Phone
    {
        public string CellPhoneNumber { get; set; }

    }

    public abstract class DeskPhone : Phone
    {
        public string DeskPhoneNumber { get; set; }
    }

}
