using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        [JsonIgnore]

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
