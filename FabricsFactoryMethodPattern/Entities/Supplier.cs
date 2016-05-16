using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Supplier : Businessperson
    {
        [BsonConstructor]
        public Supplier()
        {
        }

        public Supplier(string firstName, string lastName, string email, string address, List<Phone> cellPhone, List<Phone> deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = cellPhone;
            this.DeskPhones = deskPhone;
            this.Bank = bank;
        }

        public Supplier(string firstName, string lastName, string email, string address, Phone cellPhone, Phone deskPhone, Bank bank)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.CellPhones = new List<Phone> { cellPhone };
            this.DeskPhones = new List<Phone> { deskPhone };
            this.Bank = bank;
        }

    }
}
