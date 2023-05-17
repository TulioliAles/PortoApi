using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PortoApi.Models
{
    public partial class PortoDBContext : DbContext
    {
        public PortoDBContext()
        {
        }

        public PortoDBContext(DbContextOptions<PortoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<Movimentacao> Movimentacaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\RBPN310100110\\SQLEXPRESS;Database=PortoDB;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Container>(entity =>
            {
                entity.ToTable("Container");

                entity.HasIndex(e => e.Cliente, "UQ__Containe__00D968A58E5B3D69")
                    .IsUnique();

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeSerie)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movimentacao>(entity =>
            {
                entity.ToTable("Movimentacao");

                entity.HasIndex(e => e.Cliente, "UQ__Moviment__00D968A51A7220E0")
                    .IsUnique();

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fim).HasColumnType("datetime");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.NumeroDeContainer)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
