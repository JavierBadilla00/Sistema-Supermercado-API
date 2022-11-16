using System;
using System.Collections.Generic;



namespace Sistema_Supermercado_API.Entity
{
    public partial class CategoriaProducto
    {
        public CategoriaProducto()
        {
            Productos = new HashSet<Productos>();
        }

        public string Id { get; set; }
        public string NombreCategoria { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
