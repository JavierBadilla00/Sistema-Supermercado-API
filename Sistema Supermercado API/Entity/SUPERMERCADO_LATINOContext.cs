using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class SUPERMERCADO_LATINOContext : DbContext
    {
        public SUPERMERCADO_LATINOContext()
        {
        }

        public SUPERMERCADO_LATINOContext(DbContextOptions<SUPERMERCADO_LATINOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarritoCompras> CarritoCompras { get; set; }
        public virtual DbSet<CategoriaProducto> CategoriaProducto { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }

        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Envios> Envios { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<SociosComerciales> SociosComerciales { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public virtual DbSet<TipoTarjeta> TipoTarjeta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-64J5C9SJ;Initial Catalog=SUPERMERCADO_LATINO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarritoCompras>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idcliente)
                    .IsRequired()
                    .HasColumnName("IDCliente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto)
                    .IsRequired()
                    .HasColumnName("IDProducto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

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

            modelBuilder.Entity<CategoriaProducto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cuentas>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Idtipo)
                    .IsRequired()
                    .HasColumnName("IDTipo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdtipoNavigation)
                    .WithMany(p => p.Cuentas)
                    .HasForeignKey(d => d.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tipo_Cuenta");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto)
                    .IsRequired()
                    .HasColumnName("IDProducto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(29, 2)")
                    .HasComputedColumnSql("([PrecioUnitario]*[Cantidad])");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoD");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idcuenta)
                    .IsRequired()
                    .HasColumnName("IDCuenta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idtipo)
                    .IsRequired()
                    .HasColumnName("IDTipo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcuentaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.Idcuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas");

                entity.HasOne(d => d.IdtipoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleados");
            });

            modelBuilder.Entity<Envios>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Destinatario)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Idcarrito)
                    .IsRequired()
                    .HasColumnName("IDCarrito")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcarritoNavigation)
                    .WithMany(p => p.Envios)
                    .HasForeignKey(d => d.Idcarrito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrito");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idcategoria)
                    .IsRequired()
                    .HasColumnName("IDCategoria")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idproveedor)
                    .IsRequired()
                    .HasColumnName("IDProveedor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

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
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SociosComerciales>(entity =>
            {
                entity.HasKey(e => e.CodigoTarjeta)
                    .HasName("PK_SocioComercial");

                entity.Property(e => e.CodigoTarjeta)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto)
                    .IsRequired()
                    .HasColumnName("IDProducto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.SociosComerciales)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoS");
            });

            modelBuilder.Entity<Tarjeta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Idcliente)
                    .IsRequired()
                    .HasColumnName("IDCliente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idtipo)
                    .IsRequired()
                    .HasColumnName("IDTipo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteT");

                entity.HasOne(d => d.IdtipoNavigation)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoTarjeta");
            });

            modelBuilder.Entity<TipoCuenta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEmpleado>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePuesto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoTarjeta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
