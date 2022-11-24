using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
