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
    
    public partial class ATENCION_CITA_IN_MOTIVO
    {
        public ATENCION_CITA_IN_MOTIVO()
        {
            this.ATENCION_CITA_INCIDENCIA = new HashSet<ATENCION_CITA_INCIDENCIA>();
            this.PROC_ATENCION_MEDICA_PROG_INCI = new HashSet<PROC_ATENCION_MEDICA_PROG_INCI>();
            this.INCIDENCIAS_CATETER = new HashSet<INCIDENCIAS_CATETER>();
            this.INCIDENCIAS_SONDA_GAS = new HashSet<INCIDENCIAS_SONDA_GAS>();
        }
    
        public short ID_ACMOTIVO { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<ATENCION_CITA_INCIDENCIA> ATENCION_CITA_INCIDENCIA { get; set; }
        public virtual ICollection<PROC_ATENCION_MEDICA_PROG_INCI> PROC_ATENCION_MEDICA_PROG_INCI { get; set; }
        public virtual ICollection<INCIDENCIAS_CATETER> INCIDENCIAS_CATETER { get; set; }
        public virtual ICollection<INCIDENCIAS_SONDA_GAS> INCIDENCIAS_SONDA_GAS { get; set; }
    }
}
