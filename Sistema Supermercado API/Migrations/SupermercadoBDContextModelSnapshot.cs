﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Supermercado_API.Entities;

namespace Sistema_Supermercado_API.Migrations
{
    [DbContext(typeof(SupermercadoBDContext))]
    partial class SupermercadoBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.CarritoCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idcliente")
                        .HasColumnName("IDCliente")
                        .HasColumnType("int");

                    b.Property<int>("Idproducto")
                        .HasColumnName("IDProducto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idcliente");

                    b.HasIndex("Idproducto");

                    b.ToTable("CarritoCompras");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Contrasena")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("EsAdministrador")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Idproducto")
                        .HasColumnName("IDProducto")
                        .HasColumnType("int");

                    b.Property<int>("Idventa")
                        .HasColumnName("IDVenta")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("Idproducto");

                    b.HasIndex("Idventa");

                    b.ToTable("DetalleVenta");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Idcategoria")
                        .HasColumnName("IDCategoria")
                        .HasColumnType("int");

                    b.Property<int>("Idproveedor")
                        .HasColumnName("IDProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<decimal?>("Precio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("RutaImagen")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idcategoria");

                    b.HasIndex("Idproveedor");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Proveedores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<int>("Idcliente")
                        .HasColumnName("IDCliente")
                        .HasColumnType("int");

                    b.Property<string>("TipoTarjeta")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Idcliente");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Idcliente")
                        .HasColumnName("IDCliente")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("TotalProducto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idcliente");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.CarritoCompras", b =>
                {
                    b.HasOne("Sistema_Supermercado_API.Entities.Clientes", "IdclienteNavigation")
                        .WithMany("CarritoCompras")
                        .HasForeignKey("Idcliente")
                        .HasConstraintName("FK_ClienteC")
                        .IsRequired();

                    b.HasOne("Sistema_Supermercado_API.Entities.Productos", "IdproductoNavigation")
                        .WithMany("CarritoCompras")
                        .HasForeignKey("Idproducto")
                        .HasConstraintName("FK_ProductoC")
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.DetalleVenta", b =>
                {
                    b.HasOne("Sistema_Supermercado_API.Entities.Productos", "IdproductoNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("Idproducto")
                        .HasConstraintName("FK_ProductoD")
                        .IsRequired();

                    b.HasOne("Sistema_Supermercado_API.Entities.Venta", "IdventaNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("Idventa")
                        .HasConstraintName("FK_Venta")
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Productos", b =>
                {
                    b.HasOne("Sistema_Supermercado_API.Entities.Categorias", "IdcategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("Idcategoria")
                        .HasConstraintName("FK_Categoria")
                        .IsRequired();

                    b.HasOne("Sistema_Supermercado_API.Entities.Proveedores", "IdproveedorNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("Idproveedor")
                        .HasConstraintName("FK_Proveedor")
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Tarjeta", b =>
                {
                    b.HasOne("Sistema_Supermercado_API.Entities.Clientes", "IdclienteNavigation")
                        .WithMany("Tarjeta")
                        .HasForeignKey("Idcliente")
                        .HasConstraintName("FK_ClienteT")
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_Supermercado_API.Entities.Venta", b =>
                {
                    b.HasOne("Sistema_Supermercado_API.Entities.Clientes", "IdclienteNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("Idcliente")
                        .HasConstraintName("FK_ClienteV")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
