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
    
    public partial class CLIENTES
    {
        public CLIENTES()
        {
            this.COTIZACIONES = new HashSet<COTIZACIONES>();
            this.DETALLEFACTURAS = new HashSet<DETALLEFACTURAS>();
        }
    
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    
        public virtual ICollection<COTIZACIONES> COTIZACIONES { get; set; }
        public virtual ICollection<DETALLEFACTURAS> DETALLEFACTURAS { get; set; }
    }
}
