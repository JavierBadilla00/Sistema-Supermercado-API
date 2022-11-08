using System;
using System.Collections.Generic;


namespace Sistema_Supermercado_API.Entity
{
    public partial class DetalleVenta
    {
        public string Id { get; set; }
        public string Idproducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal? Total { get; set; }

        public virtual Productos IdproductoNavigation { get; set; }
    }
}
