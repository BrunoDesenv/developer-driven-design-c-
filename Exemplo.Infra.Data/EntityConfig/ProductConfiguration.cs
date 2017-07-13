using Exemplo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Exemplo.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        //Fluent API
        public ProductConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Price)
                .IsRequired();

            Property(x => x.Active)
                .IsRequired();

            HasRequired(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.IdCategory);
        }
    }
}
