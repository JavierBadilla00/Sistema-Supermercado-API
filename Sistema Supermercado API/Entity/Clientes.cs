using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;



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
