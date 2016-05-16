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
    public class Employee : Person
    {

        [BsonElement("birth_date")]
        public DateTime BirthDate { get; set; }

        [BsonElement("indentity_card_number")]
        public string IdentityCardNumber { get; set; }

        [BsonElement("salary")]
        public int Salary { get; set; }

        [BsonElement("join_date")]
        public DateTime JoinDate { get; set; }

        [BsonElement("degree")]
        public string Degree { get; set; }

        [BsonElement("shipper")]
        public Shipper Shipper { get; set; }

        [BsonElement("leave")]
        public List<Leave> Leave { get; set; }

        [BsonConstructor]
        public Employee()
        {
            this.JoinDate = DateTime.Now;
        }
        
        public Employee(string firstName, string lastName, string identityCardNumber, DateTime birthDate, string email, 
            string address, Phone cellPhone, Phone deskPhone, int salary, string degree, Shipper shipper)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdentityCardNumber = identityCardNumber;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Address = address;
            this.CellPhones = new List<Phone> { cellPhone };
            this.DeskPhones = new List<Phone> { deskPhone };
            this.Salary = salary;
            this.Degree = degree;
            this.Shipper = shipper;
        }

        public Employee(string firstName, string lastName, string identityCardNumber, DateTime birthDate, string email, 
            string address, Phone cellPhone, Phone deskPhone, int salary, string degree, Shipper shipper, DateTime joinDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdentityCardNumber = identityCardNumber;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Address = address;
            this.CellPhones = new List<Phone> { cellPhone };
            this.DeskPhones = new List<Phone> { deskPhone };
            this.Salary = salary;
            this.Degree = degree;
            this.Shipper = shipper;
            this.JoinDate = joinDate;
        }

    }
}
