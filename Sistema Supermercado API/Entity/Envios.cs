using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class Envios
    {
        public string Id { get; set; }
        public string Idcarrito { get; set; }
        public string Destinatario { get; set; }
        public DateTime Fecha { get; set; }

        public virtual CarritoCompras IdcarritoNavigation { get; set; }
    }
}
