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
    
    public partial class HC_DOCUMENTO_TIPO
    {
        public HC_DOCUMENTO_TIPO()
        {
            this.HISTORIA_CLINICA_DOCUMENTO = new HashSet<HISTORIA_CLINICA_DOCUMENTO>();
            this.HISTORIA_CLINICA_DENTAL_DOCUME = new HashSet<HISTORIA_CLINICA_DENTAL_DOCUME>();
        }
    
        public int ID_DOCTO { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<HISTORIA_CLINICA_DOCUMENTO> HISTORIA_CLINICA_DOCUMENTO { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_DENTAL_DOCUME> HISTORIA_CLINICA_DENTAL_DOCUME { get; set; }
    }
}