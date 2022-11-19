using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;

namespace SouDizimista.Repository.mapping
{
    public class ParoquiaMap : IEntityTypeConfiguration<Paroquia>
    {
        public void Configure(EntityTypeBuilder<Paroquia> builder)
        {
            builder.ToTable("Paroquia");
            builder.HasQueryFilter(p => !p.Deleted);

        }
    }
}
