using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class Clientes
    {
        public Clientes()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            Tarjeta = new HashSet<Tarjeta>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public bool? EsAdministrador { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
