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
    
    public partial class TV_SERVICIO_AUX_INTERCONSULTA
    {
        public int ID_SERV_AUX { get; set; }
        public int ID_TV_INTERSOL { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual SERVICIO_AUX_DIAG_TRAT SERVICIO_AUX_DIAG_TRAT { get; set; }
        public virtual TV_INTERCONSULTA_SOLICITUD TV_INTERCONSULTA_SOLICITUD { get; set; }
    }
}
