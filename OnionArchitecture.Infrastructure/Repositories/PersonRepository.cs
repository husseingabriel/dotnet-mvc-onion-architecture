using OnionArchitecture.Core.Entities;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Infrastructure.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(OnionDbContext context): base(context){ }

    }
}
