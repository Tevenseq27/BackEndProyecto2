using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entidades.Entities
{
    public partial class Proyecto2_SistemaRuteoContext : DbContext
    {
        public Proyecto2_SistemaRuteoContext()
        {
        }

        public Proyecto2_SistemaRuteoContext(DbContextOptions<Proyecto2_SistemaRuteoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<Chofer> Chofer { get; set; }
        public virtual DbSet<Recorrido> Recorrido { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SSEQUIERA_HIO03; Database=Proyecto2_SistemaRuteo; Trusted_Connection=True; user id=sa; password=masterkey;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.PlacaUnidad);

                entity.Property(e => e.PlacaUnidad)
                    .HasColumnName("placa_unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoUnidad)
                    .IsRequired()
                    .HasColumnName("estado_unidad")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroUnidad).HasColumnName("numero_unidad");
            });

            modelBuilder.Entity<Chofer>(entity =>
            {
                entity.HasKey(e => e.IdChofer);

                entity.Property(e => e.IdChofer)
                    .HasColumnName("id_chofer")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Apellido1Chofer)
                    .IsRequired()
                    .HasColumnName("apellido1_chofer")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Apellido2Chofer)
                    .IsRequired()
                    .HasColumnName("apellido2_chofer")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Nombre1Chofer)
                    .IsRequired()
                    .HasColumnName("nombre1_chofer")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Nombre2Chofer)
                    .HasColumnName("nombre2_chofer")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoChofer)
                    .IsRequired()
                    .HasColumnName("telefono_chofer")
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Recorrido>(entity =>
            {
                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdChoferAsignado)
                    .IsRequired()
                    .HasColumnName("id_chofer_asignado")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.IdRutaAsignada).HasColumnName("id_ruta_asignada");

                entity.Property(e => e.MontoRecibido).HasColumnName("monto_recibido");

                entity.Property(e => e.PlacaUnidadAsignada)
                    .IsRequired()
                    .HasColumnName("placa_unidad_asignada")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdChoferAsignadoNavigation)
                    .WithMany(p => p.Recorrido)
                    .HasForeignKey(d => d.IdChoferAsignado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recorrido_Chofer");

                entity.HasOne(d => d.IdRutaAsignadaNavigation)
                    .WithMany(p => p.Recorrido)
                    .HasForeignKey(d => d.IdRutaAsignada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recorrido_Ruta");

                entity.HasOne(d => d.PlacaUnidadAsignadaNavigation)
                    .WithMany(p => p.Recorrido)
                    .HasForeignKey(d => d.PlacaUnidadAsignada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recorrido_Bus");
            });

            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.HasKey(e => e.IdRuta);

                entity.Property(e => e.IdRuta)
                    .HasColumnName("id_ruta")
                    .ValueGeneratedNever();

                entity.Property(e => e.CantidadParadas).HasColumnName("cantidad_paradas");

                entity.Property(e => e.MontoEstimadoRuta).HasColumnName("monto_estimado_ruta");

                entity.Property(e => e.TerminalLlegada)
                    .IsRequired()
                    .HasColumnName("terminal_llegada")
                    .HasColumnType("text");

                entity.Property(e => e.TerminalSalida)
                    .IsRequired()
                    .HasColumnName("terminal_salida")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<USUARIOS>(entity =>
            {
                entity.HasKey(e => e.ID_USUARIO);

                entity.Property(e => e.ID_USUARIO)
                    .HasColumnName("ID_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.EMAIL)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.PASS)
                    .IsRequired()
                    .HasColumnName("PASS")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.SALT)
                    .IsRequired()
                    .HasColumnName("SALT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOMBRE)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.APELLIDOS)
                    .IsRequired()
                    .HasColumnName("APELLIDOS")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TIPO)
                    .HasColumnName("TIPO")
                    .HasMaxLength(15)
                    .IsFixedLength();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
