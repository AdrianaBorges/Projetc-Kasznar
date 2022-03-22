using System.Collections.Generic;
using Kasznar.Domain.Entities;

namespace Kasznar.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
