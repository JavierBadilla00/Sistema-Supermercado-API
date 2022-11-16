using System;
using System.Collections.Generic;



namespace Sistema_Supermercado_API.Entity
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Productos = new HashSet<Productos>();
        }

        public string Id { get; set; }
        public string NombreTipo { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
