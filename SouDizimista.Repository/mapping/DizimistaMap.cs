using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;

namespace SouDizimista.Repository.mapping
{
    public class DizimistaMap : IEntityTypeConfiguration<Dizimista>
    {
        public void Configure(EntityTypeBuilder<Dizimista> builder)
        {
            builder.ToTable("Dizimista");
            builder.HasQueryFilter(d => !d.Deleted);
        }
    }
}
