using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricsFactoryMethodPattern.Entities;

namespace FabricsFactoryMethodPattern.Services
{
    public abstract class PersonService<T> : EntityService<T>  where T : IEntity
    {

    }
}
