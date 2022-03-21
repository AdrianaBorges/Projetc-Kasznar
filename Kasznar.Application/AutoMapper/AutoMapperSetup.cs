using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
