using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Id { get; set; }
        public int Idcliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal Total { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaCompra { get; set; }

        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
