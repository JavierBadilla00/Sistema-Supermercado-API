using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public class Clientes
    {
        public Clientes()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            Tarjeta = new HashSet<Tarjeta>();
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        [JsonIgnore]
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }

        [JsonIgnore]
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
