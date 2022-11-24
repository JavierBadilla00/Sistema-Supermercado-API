using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sistema_Supermercado_API.Entity
{
    public partial class Tarjeta
    {
        public string Id { get; set; }
        public string Idcliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Idtipo { get; set; }
        public DateTime Vencimiento { get; set; }

        [JsonIgnore]
        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual TipoTarjeta IdtipoNavigation { get; set; }
    }
}
