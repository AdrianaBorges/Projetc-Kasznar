using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kasznar.Application.ViewModels;

namespace Kasznar.Application.Interfaces
{
    //Contrato
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
