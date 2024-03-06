using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;

namespace SouDizimista.Repository.mapping
{
    public class DizimistaMap : IEntityTypeConfiguration<CADDizimista>
    {
        public void Configure(EntityTypeBuilder<CADDizimista> builder)
        {
            builder.ToTable("CADDizimista");
            builder.HasQueryFilter(d => !d.Deleted);
        }
    }
}
