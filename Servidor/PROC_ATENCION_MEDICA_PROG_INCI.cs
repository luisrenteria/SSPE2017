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
    
    public partial class PROC_ATENCION_MEDICA_PROG_INCI
    {
        public int ID_AM_PROG_IN { get; set; }
        public int ID_AM_PROG { get; set; }
        public Nullable<short> ID_ACMOTIVO { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public string OBSERVACIONES { get; set; }
        public int ID_ATENCION_MEDICA { get; set; }
        public short ID_PROCMED { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual ATENCION_CITA_IN_MOTIVO ATENCION_CITA_IN_MOTIVO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual PROC_ATENCION_MEDICA_PROG PROC_ATENCION_MEDICA_PROG { get; set; }
    }
}
