using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TutorialEntityFrameWorkCore.Model
{
    public partial class EjemploEntityContext : DbContext
    {
        public EjemploEntityContext()
        {
        }

        public EjemploEntityContext(DbContextOptions<EjemploEntityContext> options)
            : base(options)
        {
        }
        /*instalando entityframework core (SQL Server)
         install-package Microsoft.EntityFrameWorkCore.sqlserver
        Instalando el tools: install-package Microsoft.EntityFrameWorkCore.tools

        Usando el Scraffolding Scaffold-DbContext "Server=.\SQLExpress;Database=EjemploEntity;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model
         add-migration migracion
        update database
         */

        public virtual DbSet<Mascotas> Mascotas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=EjemploEntity;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Mascotas>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Raza)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
