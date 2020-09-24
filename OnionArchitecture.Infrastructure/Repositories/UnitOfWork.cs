using OnionArchitecture.Core.Entities;
using OnionArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnionDbContext _context;
        private readonly IPersonRepository _personRepository;
        public IPersonRepository PersonRepository => _personRepository ?? new PersonRepository(_context);

        public UnitOfWork(OnionDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
