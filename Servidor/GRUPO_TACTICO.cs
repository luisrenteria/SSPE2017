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
    
    public partial class GRUPO_TACTICO
    {
        public GRUPO_TACTICO()
        {
            this.DECOMISO = new HashSet<DECOMISO>();
        }
    
        public short ID_GRUPO_TACTICO { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<DECOMISO> DECOMISO { get; set; }
    }
}
