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
    
    public partial class TIPO_VISITA
    {
        public TIPO_VISITA()
        {
            this.PERSONA_NIP = new HashSet<PERSONA_NIP>();
            this.TIPO_DOCUMENTO = new HashSet<TIPO_DOCUMENTO>();
            this.VISITA_AUTORIZADA = new HashSet<VISITA_AUTORIZADA>();
            this.VISITA_AGENDA = new HashSet<VISITA_AGENDA>();
            this.VISITA_APELLIDO = new HashSet<VISITA_APELLIDO>();
            this.VISITA_EDIFICIO = new HashSet<VISITA_EDIFICIO>();
            this.VISITA_EXTERNA = new HashSet<VISITA_EXTERNA>();
        }
    
        public short ID_TIPO_VISITA { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<PERSONA_NIP> PERSONA_NIP { get; set; }
        public virtual ICollection<TIPO_DOCUMENTO> TIPO_DOCUMENTO { get; set; }
        public virtual ICollection<VISITA_AUTORIZADA> VISITA_AUTORIZADA { get; set; }
        public virtual ICollection<VISITA_AGENDA> VISITA_AGENDA { get; set; }
        public virtual ICollection<VISITA_APELLIDO> VISITA_APELLIDO { get; set; }
        public virtual ICollection<VISITA_EDIFICIO> VISITA_EDIFICIO { get; set; }
        public virtual ICollection<VISITA_EXTERNA> VISITA_EXTERNA { get; set; }
    }
}
