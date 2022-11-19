using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;

namespace SouDizimista.Repository.mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasQueryFilter(e => !e.Deleted);
        }
    }
}
