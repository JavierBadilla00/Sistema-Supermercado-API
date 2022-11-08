using System;
using System.Collections.Generic;



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
