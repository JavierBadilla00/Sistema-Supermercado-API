using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class SociosComerciales
    {
        public string CodigoTarjeta { get; set; }
        public string Nombre { get; set; }
        public string Idproducto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public virtual Productos IdproductoNavigation { get; set; }
    }
}
