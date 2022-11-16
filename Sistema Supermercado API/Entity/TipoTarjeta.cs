using System;
using System.Collections.Generic;



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
