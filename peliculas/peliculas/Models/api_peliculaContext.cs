using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace peliculas.Models
{
    public partial class api_peliculaContext : DbContext
    {
        public api_peliculaContext()
        {
        }

        public api_peliculaContext(DbContextOptions<api_peliculaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AP83LF2M; Database=api_pelicula; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.IdPelicula);

                entity.ToTable("pelicula");

                entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");

                entity.Property(e => e.Director)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("director");

                entity.Property(e => e.Genero)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.Publicacion)
                    .HasColumnType("date")
                    .HasColumnName("publicacion");

                entity.Property(e => e.Puntuacion).HasColumnName("puntuacion");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
