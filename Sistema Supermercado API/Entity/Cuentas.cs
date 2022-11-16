using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class Cuentas
    {
        public Cuentas()
        {
            Empleados = new HashSet<Empleados>();
        }

        public string Id { get; set; }
        public string Idtipo { get; set; }
        public string NumeroCuenta { get; set; }
        public string Descripcion { get; set; }

        [JsonIgnore]
        public virtual TipoCuenta IdtipoNavigation { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
