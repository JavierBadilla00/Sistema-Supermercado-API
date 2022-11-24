using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sistema_Supermercado_API.Entity
{
    public partial class Empleados
    {
        public string Codigo { get; set; }
        public string Idtipo { get; set; }
        public string Idcuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        [JsonIgnore]
        public virtual Cuentas IdcuentaNavigation { get; set; }
        public virtual TipoEmpleado IdtipoNavigation { get; set; }
    }
}
