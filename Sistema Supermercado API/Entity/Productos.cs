using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sistema_Supermercado_API.Entity
{
    public partial class Productos
    {
        public Productos()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            DetalleVenta = new HashSet<DetalleVenta>();
            SociosComerciales = new HashSet<SociosComerciales>();
        }

        public string Id { get; set; }
        public string Idproveedor { get; set; }
        public string Idcategoria { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        [JsonIgnore]

        public virtual CategoriaProducto IdcategoriaNavigation { get; set; }
        public virtual Proveedores IdproveedorNavigation { get; set; }
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<SociosComerciales> SociosComerciales { get; set; }
    }
}
