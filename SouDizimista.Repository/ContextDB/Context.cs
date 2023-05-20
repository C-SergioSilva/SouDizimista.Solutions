using Microsoft.EntityFrameworkCore;
using SouDizimista.Domain.Entities;
using System.Reflection;

namespace SouDizimista.Repository.ContextDB
{
    public class Context : DbContext
    {
        public DbSet<Paroquia> Paroquias { get; set; }
        public DbSet<Dizimista> Dizimistas { get; set; }
        public Context(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
