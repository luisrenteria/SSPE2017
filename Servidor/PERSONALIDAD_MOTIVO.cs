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
    
    public partial class PERSONALIDAD_MOTIVO
    {
        public PERSONALIDAD_MOTIVO()
        {
            this.PERSONALIDAD = new HashSet<PERSONALIDAD>();
        }
    
        public short ID_MOTIVO { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<PERSONALIDAD> PERSONALIDAD { get; set; }
    }
}