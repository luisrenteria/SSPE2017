//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSP.Servidor
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRESENTACION
    {
        public PRESENTACION()
        {
            this.PRODUCTO_PRESENTACION = new HashSet<PRODUCTO_PRESENTACION>();
        }
    
        public short ID_PRESENTACION { get; set; }
        public string DESCR { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual ICollection<PRODUCTO_PRESENTACION> PRODUCTO_PRESENTACION { get; set; }
    }
}