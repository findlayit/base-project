using System.Data.Entity;
using BaseProject.Domain.Users;

namespace BaseProject.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<UserContext>(null);
        }

        // DbSets
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                   .HasMany<RoleEntity>(s => s.Roles)
                   .WithMany(c => c.Users)
                   .Map(cs =>
                   {
                       cs.MapLeftKey("UserId");
                       cs.MapRightKey("RoleId");
                       cs.ToTable("UserRoles");
                   });
        }

    }
}