using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Contexto : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Data Source =.\; Initial Catalog = Estudo; Integrated Security = True"
            optionsBuilder.UseSqlServer(@"Data Source=NT000810;Initial Catalog=atividade;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_usuarios");
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Numero)
                    .IsRequired();
                entity.Property(e => e.DataNascimento)
                    .IsRequired();
                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11);
            });
        }
    }
}