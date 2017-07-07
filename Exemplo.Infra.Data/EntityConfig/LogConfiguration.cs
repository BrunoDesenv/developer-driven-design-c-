using Exemplo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Exemplo.Infra.Data.EntityConfig
{
    public class LogConfiguration : EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.IdAcao)
                .IsRequired();

            Property(x => x.IP)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Browser)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Mensagem)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.DataCadastro)
                .IsRequired();

            Property(x => x.IdResponsible);

            HasRequired(x => x.Responsible).WithMany().HasForeignKey(x => x.IdResponsible);
        }
    }
}
