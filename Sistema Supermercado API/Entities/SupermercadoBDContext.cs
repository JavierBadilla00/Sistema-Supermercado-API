using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class SupermercadoBDContext : DbContext
    {
        public SupermercadoBDContext()
        {
        }

        public SupermercadoBDContext(DbContextOptions<SupermercadoBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarritoCompras> CarritoCompras { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Data Source=DESKTOP-A6B0DKK;Initial Catalog=SupermercadoBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarritoCompras>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Idproducto).HasColumnName("IDProducto");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteC");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoC");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idproducto).HasColumnName("IDProducto");

                entity.Property(e => e.Idventa).HasColumnName("IDVenta");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoD");

                entity.HasOne(d => d.IdventaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Idventa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Venta");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcategoria).HasColumnName("IDCategoria");

                entity.Property(e => e.Idproveedor).HasColumnName("IDProveedor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RutaImagen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categoria");

                entity.HasOne(d => d.IdproveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Idproveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proveedor");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tarjeta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.TipoTarjeta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteT");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
