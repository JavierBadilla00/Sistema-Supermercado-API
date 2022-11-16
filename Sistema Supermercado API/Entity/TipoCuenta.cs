
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;



namespace Sistema_Supermercado_API.Entity
{
    public partial class TipoCuenta
    {
        public TipoCuenta()
        {
            Cuentas = new HashSet<Cuentas>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }

        [JsonIgnore]
        public virtual ICollection<Cuentas> Cuentas { get; set; }
    }
}
