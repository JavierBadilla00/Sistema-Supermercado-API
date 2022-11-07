using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class Tarjeta
    {
        public string Id { get; set; }
        public string Idcliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Idtipo { get; set; }
        public DateTime Vencimiento { get; set; }

        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual TipoTarjeta IdtipoNavigation { get; set; }
    }
}
