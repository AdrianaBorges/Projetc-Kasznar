using Kasznar.Data.Extensions;
using Kasznar.Data.Mappings;
using Kasznar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kasznar.Data.Context
{
    public class KasznarContext: DbContext
    {
        //Construtor da classe
        public KasznarContext(DbContextOptions<KasznarContext> option)
            : base(option) { }

        #region "DBSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyGlobalConfigurations();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }

    }
}
