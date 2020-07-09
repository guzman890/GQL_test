using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GQLTest.Data.models
{
    public partial class DBYoinTestContext : DbContext
    {
        public DBYoinTestContext()
        {
        }

        public DBYoinTestContext(DbContextOptions<DBYoinTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PedidoQuery> PedidoQuery { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=pruebaqa.sreasons.com;Database=DBYoinTest;User ID=usuariosmart;Password=$P3ru123.");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoQuery>(entity =>
            {
                entity.HasKey(e => e.IdPedidoQuery)
                    .HasName("PK__PedidoQu__250A9096C337F8D4");

                entity.Property(e => e.DenominacionCliente)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionEmpresa)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionRepartidor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionSucursal)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoCliente)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoEmpresa)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoRepartidor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoPedido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.Property(e => e.LatitudEntrega).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LatitudRetiro).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LogFechacrea).HasColumnType("datetime");

                entity.Property(e => e.LogFechamodif).HasColumnType("datetime");

                entity.Property(e => e.LogUsuariocrea)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogUsuariomodif)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongitudEntrega).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LongitudRetiro).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.MetodoPago)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoDelivery).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MontoDescuento).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MontoSubtotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MontoTotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ReferenciaEntrega)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaRetiro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEntrega)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoRetiro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDelivery)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionEntrega)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionRetiro)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
