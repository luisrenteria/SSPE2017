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
    
    public partial class PERSONA_EXTERNO
    {
        public PERSONA_EXTERNO()
        {
            this.VISITA_EXTERNA = new HashSet<VISITA_EXTERNA>();
        }
    
        public Nullable<short> ID_CENTRO { get; set; }
        public int ID_PERSONA { get; set; }
        public string ESTATUS { get; set; }
        public byte[] CREDENCIAL_FRENTE { get; set; }
        public byte[] CREDENCIAL_DETRAS { get; set; }
        public string OBSERV { get; set; }
        public Nullable<short> ID_TIPO_VISITANTE { get; set; }
    
        public virtual CENTRO CENTRO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual TIPO_VISITANTE TIPO_VISITANTE { get; set; }
        public virtual ICollection<VISITA_EXTERNA> VISITA_EXTERNA { get; set; }
    }
}
