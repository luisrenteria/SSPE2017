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
    
    public partial class TRASLADO_MOTIVO
    {
        public TRASLADO_MOTIVO()
        {
            this.TRASLADO = new HashSet<TRASLADO>();
        }
    
        public short ID_MOTIVO { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<TRASLADO> TRASLADO { get; set; }
    }
}
