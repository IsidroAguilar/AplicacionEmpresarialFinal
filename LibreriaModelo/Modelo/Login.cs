//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaModelo.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int IdLogin { get; set; }
        public int IdUsuario { get; set; }
        public System.DateTime FechaHora { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
