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
    
    public partial class TRASLADO_DETALLE_ESTATUS
    {
        public TRASLADO_DETALLE_ESTATUS()
        {
            this.TRASLADO_DETALLE = new HashSet<TRASLADO_DETALLE>();
        }
    
        public string ID_ESTATUS { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<TRASLADO_DETALLE> TRASLADO_DETALLE { get; set; }
    }
}
