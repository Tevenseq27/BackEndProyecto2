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
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Recorrido> Recorrido { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

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

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.CodigoPerfil)
                    .HasName("PK__Perfil__E317F5E6F68EE274");

                entity.Property(e => e.CodigoPerfil).HasColumnName("codigo_perfil");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.NombrePerfil)
                    .IsRequired()
                    .HasColumnName("nombre_perfil")
                    .HasMaxLength(255)
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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Apellido1Usuario)
                    .IsRequired()
                    .HasColumnName("apellido1_usuario")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Apellido2Usuario)
                    .IsRequired()
                    .HasColumnName("apellido2_usuario")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.CodPerfilUsuario).HasColumnName("cod_perfil_usuario");

                entity.Property(e => e.ContraseñaUsuario)
                    .IsRequired()
                    .HasColumnName("contraseña_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoUsuario)
                    .IsRequired()
                    .HasColumnName("correo_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1Usuario)
                    .IsRequired()
                    .HasColumnName("nombre1_usuario")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Nombre2Usuario)
                    .HasColumnName("nombre2_usuario")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPerfilUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CodPerfilUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
