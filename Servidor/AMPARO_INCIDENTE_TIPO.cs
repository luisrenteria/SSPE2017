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
    
    public partial class AMPARO_INCIDENTE_TIPO
    {
        public AMPARO_INCIDENTE_TIPO()
        {
            this.AMPARO_INCIDENTE = new HashSet<AMPARO_INCIDENTE>();
        }
    
        public short ID_AMP_INC_TIPO { get; set; }
        public string DESCR { get; set; }
        public string APLICA_CAUSA_PENAL { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<AMPARO_INCIDENTE> AMPARO_INCIDENTE { get; set; }
    }
}
