using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SouDizimista.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Repository.mapping
{
    public class CADEnderecoMap : IEntityTypeConfiguration<Endereco> 
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("CADEndereco");
            builder.HasQueryFilter(e => !e.Deleted);
        }
    }
}






