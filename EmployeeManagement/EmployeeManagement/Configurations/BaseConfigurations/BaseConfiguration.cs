using EmployeeManagement.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Configurations.BaseConfigurations
{
    public static class BaseConfiguration 
    {
        public static EntityTypeBuilder<TEntity> AddBaseEntityConfiguration<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : BaseEntity<string>
        {
            builder.Property(b => b.IsDeleted).HasDefaultValue(false);
            builder.Property(b => b.Id).HasDefaultValue("NEWID()");
                return builder;
        }
        public static EntityTypeBuilder<TEntity> AddBaseAuiditableConfiguration<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : BaseAuditable<string>
        {
            builder.AddBaseEntityConfiguration();
            builder.Property(b => b.CreatedAt).HasDefaultValue("GETDATE()");
            builder.Property(b => b.ModifiedAt).IsRequired(false);
            builder.Property(b => b.UpdatedBy).IsRequired(false);
            builder.Property(b=>b.IsDeleted).HasDefaultValue(false);
            return builder;
        }
       
    }
}
