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
    
    public partial class TIPO_DOCUMENTO_MEDIDA
    {
        public TIPO_DOCUMENTO_MEDIDA()
        {
            this.MEDIDA_DOCUMENTO = new HashSet<MEDIDA_DOCUMENTO>();
        }
    
        public decimal ID_TIPDOCMED { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
        public string SENTIDO { get; set; }
    
        public virtual ICollection<MEDIDA_DOCUMENTO> MEDIDA_DOCUMENTO { get; set; }
    }
}
