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
    
    public partial class CAUSA_PENAL_ESTATUS
    {
        public CAUSA_PENAL_ESTATUS()
        {
            this.CAUSA_PENAL = new HashSet<CAUSA_PENAL>();
        }
    
        public short ID_ESTATUS_CP { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<CAUSA_PENAL> CAUSA_PENAL { get; set; }
    }
}
