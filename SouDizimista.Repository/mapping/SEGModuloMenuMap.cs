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
    public class SEGModuloMenuMap : IEntityTypeConfiguration<MenuItemLateral> 
    {
        public void Configure(EntityTypeBuilder<MenuItemLateral> builder)
        {
            builder.ToTable("SEGModuloMenuMap");
            builder.HasQueryFilter(d => !d.Deleted);
        }
    }
}
