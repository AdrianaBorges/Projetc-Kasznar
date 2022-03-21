using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kasznar.Data.Context;
using Kasznar.Domain.Entities;
using Kasznar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

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
