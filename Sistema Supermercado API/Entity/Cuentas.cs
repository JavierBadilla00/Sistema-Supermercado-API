using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;



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
