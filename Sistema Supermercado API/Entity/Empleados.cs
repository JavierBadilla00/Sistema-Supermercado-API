﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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

        public virtual Cuentas IdcuentaNavigation { get; set; }
        public virtual TipoEmpleado IdtipoNavigation { get; set; }
    }
}
