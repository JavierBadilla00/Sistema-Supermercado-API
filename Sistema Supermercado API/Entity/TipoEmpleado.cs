using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entity
{
    public partial class TipoEmpleado
    {
        public TipoEmpleado()
        {
            Empleados = new HashSet<Empleados>();
        }

        public string Id { get; set; }
        public string NombrePuesto { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
