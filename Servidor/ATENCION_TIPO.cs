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
    
    public partial class ATENCION_TIPO
    {
        public ATENCION_TIPO()
        {
            this.ATENCION_SERVICIO = new HashSet<ATENCION_SERVICIO>();
            this.PROC_MED_SUBTIPO = new HashSet<PROC_MED_SUBTIPO>();
            this.ATENCION_SOLICITUD = new HashSet<ATENCION_SOLICITUD>();
        }
    
        public short ID_TIPO_ATENCION { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<ATENCION_SERVICIO> ATENCION_SERVICIO { get; set; }
        public virtual ICollection<PROC_MED_SUBTIPO> PROC_MED_SUBTIPO { get; set; }
        public virtual ICollection<ATENCION_SOLICITUD> ATENCION_SOLICITUD { get; set; }
    }
}
