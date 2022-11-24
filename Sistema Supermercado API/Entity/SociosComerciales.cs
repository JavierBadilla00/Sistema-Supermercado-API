using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sistema_Supermercado_API.Entity
{
    public partial class SociosComerciales
    {
        public string CodigoTarjeta { get; set; }
        public string Nombre { get; set; }
        public string Idproducto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        [JsonIgnore]
        public virtual Productos IdproductoNavigation { get; set; }
    }
}
