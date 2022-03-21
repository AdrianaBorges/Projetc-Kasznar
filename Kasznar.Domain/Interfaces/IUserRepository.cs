using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kasznar.Domain.Entities;

namespace Kasznar.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
