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
    
    public partial class ESPECIALISTA_CITA
    {
        public short ID_ESPECIALIDAD { get; set; }
        public int ID_CITA { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public Nullable<int> ID_SOLICITUD { get; set; }
        public short ID_CENTRO_UBI { get; set; }
        public short ID_ESPECIALISTA { get; set; }
    
        public virtual ATENCION_CITA ATENCION_CITA { get; set; }
        public virtual ESPECIALISTA ESPECIALISTA { get; set; }
        public virtual SOL_INTERCONSULTA_INTERNA SOL_INTERCONSULTA_INTERNA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
