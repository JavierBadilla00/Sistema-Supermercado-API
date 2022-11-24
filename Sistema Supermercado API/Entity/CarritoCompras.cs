using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        [JsonIgnore]

        public virtual Clientes IdclienteNavigation { get; set; }
        public virtual Productos IdproductoNavigation { get; set; }
        public virtual ICollection<Envios> Envios { get; set; }
    }
}
