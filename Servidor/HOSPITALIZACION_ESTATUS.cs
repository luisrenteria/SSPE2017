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
    
    public partial class HOSPITALIZACION_ESTATUS
    {
        public HOSPITALIZACION_ESTATUS()
        {
            this.HOSPITALIZACION = new HashSet<HOSPITALIZACION>();
        }
    
        public decimal ID_HOSEST { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<HOSPITALIZACION> HOSPITALIZACION { get; set; }
    }
}
