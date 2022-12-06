using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Supermercado_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Apellidos = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Correo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Contrasena = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    EsAdministrador = table.Column<bool>(nullable: true),
                    Activo = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipo = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCliente = table.Column<int>(nullable: false),
                    TipoTarjeta = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteT",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCliente = table.Column<int>(nullable: false),
                    TotalProducto = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Contacto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    FechaCompra = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteV",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    IDProveedor = table.Column<int>(nullable: false),
                    IDCategoria = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10, 2)", nullable: true, defaultValueSql: "((0))"),
                    Stock = table.Column<int>(nullable: true),
                    RutaImagen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Activo = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categoria",
                        column: x => x.IDCategoria,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor",
                        column: x => x.IDProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarritoCompras",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProducto = table.Column<int>(nullable: false),
                    IDCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoCompras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteC",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductoC",
                        column: x => x.IDProducto,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDVenta = table.Column<int>(nullable: false),
                    IDProducto = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductoD",
                        column: x => x.IDProducto,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Venta",
                        column: x => x.IDVenta,
                        principalTable: "Venta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoCompras_IDCliente",
                table: "CarritoCompras",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoCompras_IDProducto",
                table: "CarritoCompras",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IDProducto",
                table: "DetalleVenta",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IDVenta",
                table: "DetalleVenta",
                column: "IDVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IDCategoria",
                table: "Productos",
                column: "IDCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IDProveedor",
                table: "Productos",
                column: "IDProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_IDCliente",
                table: "Tarjeta",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IDCliente",
                table: "Venta",
                column: "IDCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoCompras");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
