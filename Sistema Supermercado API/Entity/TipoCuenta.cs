
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
