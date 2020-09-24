using OnionArchitecture.Core.Entities;
using OnionArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Person> GetPerson()
        {
            return _unitOfWork.PersonRepository.GetAll();
        }

        public Task<Person> GetPerson(int id)
        {
            return _unitOfWork.PersonRepository.GetById(id);
        }

        public void Add(Person person)
        {
            _unitOfWork.PersonRepository.Add(person);
            _unitOfWork.SaveChanges();
        }

        public void Update(Person person)
        {
            _unitOfWork.PersonRepository.Update(person);
            _unitOfWork.SaveChanges();
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.PersonRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
