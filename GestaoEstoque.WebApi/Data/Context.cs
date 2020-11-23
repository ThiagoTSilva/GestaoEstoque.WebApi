using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GestaoEstoque.WebApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>().ToTable("Agenda");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }

    }
}
