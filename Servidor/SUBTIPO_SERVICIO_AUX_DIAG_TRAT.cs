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
    
    public partial class SUBTIPO_SERVICIO_AUX_DIAG_TRAT
    {
        public SUBTIPO_SERVICIO_AUX_DIAG_TRAT()
        {
            this.SERVICIO_AUX_DIAG_TRAT = new HashSet<SERVICIO_AUX_DIAG_TRAT>();
        }
    
        public short ID_SUBTIPO_SADT { get; set; }
        public Nullable<short> ID_TIPO_SADT { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual TIPO_SERVICIO_AUX_DIAG_TRAT TIPO_SERVICIO_AUX_DIAG_TRAT { get; set; }
        public virtual ICollection<SERVICIO_AUX_DIAG_TRAT> SERVICIO_AUX_DIAG_TRAT { get; set; }
    }
}
