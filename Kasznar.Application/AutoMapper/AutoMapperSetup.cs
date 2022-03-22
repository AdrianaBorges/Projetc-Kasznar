using System.Diagnostics;
using AutoMapper;
using Kasznar.Application.ViewModels;
using Kasznar.Domain.Entities;

namespace Kasznar.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewwModelToDomain

            CreateMap<UserViewModel, DebuggerNonUserCodeAttribute>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
