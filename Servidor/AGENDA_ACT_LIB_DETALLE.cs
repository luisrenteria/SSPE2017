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
    
    public partial class AGENDA_ACT_LIB_DETALLE
    {
        public decimal ID_AGENDA_ACTIVIDAD_LIBERTAD { get; set; }
        public decimal ID_DETALLE { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> HORA_INICIO { get; set; }
        public Nullable<System.DateTime> HORA_FIN { get; set; }
        public Nullable<decimal> ASISTENCIA { get; set; }
        public string OBSERVACION { get; set; }
    
        public virtual AGENDA_ACTIVIDAD_LIBERTAD AGENDA_ACTIVIDAD_LIBERTAD { get; set; }
    }
}
