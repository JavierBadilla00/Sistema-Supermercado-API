using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class CarritoCompras
    {
        public CarritoCompras()
        {
            Envios = new HashSet<Envios>();
        }

        public string Id { get; set; }
        public string Idproducto { get; set; }
        public string Idcliente { get; set; }

        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual Productos IdproductoNavigation { get; set; }
        public virtual ICollection<Envios> Envios { get; set; }
    }
}
