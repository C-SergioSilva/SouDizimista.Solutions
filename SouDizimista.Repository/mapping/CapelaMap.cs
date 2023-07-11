using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;

namespace SouDizimista.Repository.mapping
{
    public class CapelaMap : IEntityTypeConfiguration<Capela>
    {
        public void Configure(EntityTypeBuilder<Capela> builder)
        {
            builder.ToTable("Capela");
            builder.HasQueryFilter(d => !d.Deleted);
        }
    }
}
