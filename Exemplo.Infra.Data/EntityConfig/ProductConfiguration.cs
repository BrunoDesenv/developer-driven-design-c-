using Exemplo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Property(x => x.Valor)
                .IsRequired();
        }
    }
}
