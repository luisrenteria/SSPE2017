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
    
    public partial class PFC_IV_DISFUNCION
    {
        public PFC_IV_DISFUNCION()
        {
            this.PFC_IV_PSICOLOGICO = new HashSet<PFC_IV_PSICOLOGICO>();
        }
    
        public short ID_DISFUNCION { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<PFC_IV_PSICOLOGICO> PFC_IV_PSICOLOGICO { get; set; }
    }
}
