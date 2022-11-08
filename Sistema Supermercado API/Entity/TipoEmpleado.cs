using System;
using System.Collections.Generic;



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
