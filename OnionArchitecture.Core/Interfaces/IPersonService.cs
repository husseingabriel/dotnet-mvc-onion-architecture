using OnionArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPerson();
        Task<Person> GetPerson(int id);
        void Add(Person person);
        void Update(Person person);
        Task Delete(int id);
    }
}
