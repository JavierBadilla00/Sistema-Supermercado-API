using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class CarritoCompras
    {
        public int Id { get; set; }
        public int Idproducto { get; set; }
        public int Idcliente { get; set; }

        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual Productos IdproductoNavigation { get; set; }
    }
}
