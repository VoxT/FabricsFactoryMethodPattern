using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;

    public interface IEntityService<T> where T : IEntity
    {
        void Create(T entity);

        bool Delete(string id);

        T GetById(string id);

        void Update(T entity);
    }
}
