using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Kasznar.Domain.Entities;
using Kasznar.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kasznar.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;

                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;

                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        
                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;

                        default:
                            break;
                    }
                }
            }

            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("c7dce21b-d207-4869-bf5f-08eb138bb919"), 
                               Name = "User Default", 
                               Email = "userdefault@kasznar.com",
                               DateCreated = new DateTime(2020,2,2),
                               IsDeleted = false,
                               DateUpdated = null
                    }
                );
            return builder;
        } 
    }
}
