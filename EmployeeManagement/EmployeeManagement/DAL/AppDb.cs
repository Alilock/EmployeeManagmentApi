using EmployeeManagement.Entities;
using EmployeeManagement.Entities.Base;
using EmployeeManagement.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeManagement.DAL
{
    public class AppDb : IdentityDbContext<AppUser,AppRole,string>
    {
        public AppDb(DbContextOptions<AppDb> opt):base(opt) { }
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<EntityEntry<BaseEntity>> entities = ChangeTracker.Entries<BaseEntity>();
            foreach (EntityEntry<BaseEntity> entity in entities)
            {
                if (entity.State == EntityState.Deleted)
                {
                    entity.Entity.IsDeleted = true;

                }
            }
            IEnumerable<EntityEntry<BaseAuditable>> enityAuditables = ChangeTracker.Entries<BaseAuditable>();
            foreach (EntityEntry<BaseAuditable> entity2 in enityAuditables)
            {
                if (entity2.State == EntityState.Deleted)
                {
                    entity2.Entity.IsDeleted=true;
                }else if(entity2.State == EntityState.Modified)
                {
                    entity2.Entity.ModifiedAt = DateTime.Now;
                }
            }


            return base.SaveChangesAsync(cancellationToken);
        }
       

    }
}
