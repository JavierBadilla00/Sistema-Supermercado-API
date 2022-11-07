using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Supermercado_API.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaProducto",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NombreCategoria = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProducto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Apellidos = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Correo = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NombreTipo = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuenta",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuenta", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmpleado",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NombrePuesto = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpleado", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarjeta",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarjeta", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDProveedor = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDCategoria = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categoria",
                        column: x => x.IDCategoria,
                        principalTable: "CategoriaProducto",
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
                name: "Cuentas",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDTipo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    NumeroCuenta = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tipo_Cuenta",
                        column: x => x.IDTipo,
                        principalTable: "TipoCuenta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDCliente = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    IDTipo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteT",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "Cedula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoTarjeta",
                        column: x => x.IDTipo,
                        principalTable: "TipoTarjeta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarritoCompras",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDProducto = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDCliente = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoCompras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClienteC",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "Cedula",
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
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDProducto = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(29, 2)", nullable: true, computedColumnSql: "([PrecioUnitario]*[Cantidad])")
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
                });

            migrationBuilder.CreateTable(
                name: "SociosComerciales",
                columns: table => new
                {
                    CodigoTarjeta = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDProducto = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Correo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocioComercial", x => x.CodigoTarjeta);
                    table.ForeignKey(
                        name: "FK_ProductoS",
                        column: x => x.IDProducto,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Codigo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDTipo = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDCuenta = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Apellidos = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Correo = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Cuentas",
                        column: x => x.IDCuenta,
                        principalTable: "Cuentas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados",
                        column: x => x.IDTipo,
                        principalTable: "TipoEmpleado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    ID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    IDCarrito = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Destinatario = table.Column<string>(type: "text", nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carrito",
                        column: x => x.IDCarrito,
                        principalTable: "CarritoCompras",
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
                name: "IX_Cuentas_IDTipo",
                table: "Cuentas",
                column: "IDTipo");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IDProducto",
                table: "DetalleVenta",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IDCuenta",
                table: "Empleados",
                column: "IDCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IDTipo",
                table: "Empleados",
                column: "IDTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IDCarrito",
                table: "Envios",
                column: "IDCarrito");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IDCategoria",
                table: "Productos",
                column: "IDCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IDProveedor",
                table: "Productos",
                column: "IDProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_SociosComerciales_IDProducto",
                table: "SociosComerciales",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_IDCliente",
                table: "Tarjeta",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_IDTipo",
                table: "Tarjeta",
                column: "IDTipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "SociosComerciales");

            migrationBuilder.DropTable(
                name: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "TipoEmpleado");

            migrationBuilder.DropTable(
                name: "CarritoCompras");

            migrationBuilder.DropTable(
                name: "TipoTarjeta");

            migrationBuilder.DropTable(
                name: "TipoCuenta");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "CategoriaProducto");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
