//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAGINAINVENTARIO.MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOSDEUSUARIOS
    {
        public TIPOSDEUSUARIOS()
        {
            this.USUARIOS = new HashSet<USUARIOS>();
        }
    
        public int Id_tipoU { get; set; }
        public string Tipo { get; set; }
    
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
