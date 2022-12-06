using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class DetalleVenta
    {
        public int Id { get; set; }
        public int Idventa { get; set; }
        public int Idproducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Total { get; set; }

        public virtual Productos IdproductoNavigation { get; set; }
        public virtual Venta IdventaNavigation { get; set; }
    }
}
