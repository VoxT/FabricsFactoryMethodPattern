using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern
{
    public class GenericFactory<T>
       where T : new()
    {
        public T CreateObject()
        {
            return new T();
        }
    }
}
