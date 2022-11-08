using System;
using System.Collections.Generic;



namespace Sistema_Supermercado_API.Entity
{
    public partial class Clientes
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

        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
