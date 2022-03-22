using System.Collections.Generic;
using Kasznar.Data.Context;
using Kasznar.Domain.Entities;
using Kasznar.Domain.Interfaces;

namespace Kasznar.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(KasznarContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

    }
}
