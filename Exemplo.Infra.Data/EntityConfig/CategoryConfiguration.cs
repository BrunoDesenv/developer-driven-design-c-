using Exemplo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Exemplo.Infra.Data.EntityConfig
{
   public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Active)
                .IsRequired();
        }
    }
}
