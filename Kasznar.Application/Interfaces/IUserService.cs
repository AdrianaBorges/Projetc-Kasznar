using System.Collections.Generic;
using Kasznar.Application.ViewModels;

namespace Kasznar.Application.Interfaces
{
    //Contrato
    public interface IUserService
    {
        List<UserViewModel> Get();
        bool Post(UserViewModel userViewModel);
        UserViewModel GetById(string id);
        bool Put(UserViewModel userViewModel);
        bool Delete(string id);
        UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user);

    }
}
