using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class TipoTarjeta
    {
        public TipoTarjeta()
        {
            Tarjeta = new HashSet<Tarjeta>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
