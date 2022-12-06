using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_Supermercado_API.Entities
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string NombreTipo { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
