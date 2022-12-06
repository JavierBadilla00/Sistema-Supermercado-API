using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class Productos
    {
        public Productos()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idproveedor { get; set; }
        public int Idcategoria { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public string RutaImagen { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Categorias IdcategoriaNavigation { get; set; }
        public virtual Proveedores IdproveedorNavigation { get; set; }
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
