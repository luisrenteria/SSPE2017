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
    
    public partial class VISITANTE
    {
        public VISITANTE()
        {
            this.VISITANTE_INGRESO = new HashSet<VISITANTE_INGRESO>();
        }
    
        public int ID_PERSONA { get; set; }
        public Nullable<short> ID_ESTATUS_VISITA { get; set; }
        public Nullable<System.DateTime> FEC_ALTA { get; set; }
        public Nullable<System.DateTime> ULTIMA_MODIFICACION { get; set; }
        public string ESTATUS_MOTIVO { get; set; }
    
        public virtual ESTATUS_VISITA ESTATUS_VISITA { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual ICollection<VISITANTE_INGRESO> VISITANTE_INGRESO { get; set; }
    }
}
