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
    
    public partial class EVENTO_INF_TECNICA
    {
        public int ID_EVENTO { get; set; }
        public short ID_CONSEC { get; set; }
        public string DESCR { get; set; }
    
        public virtual EVENTO EVENTO { get; set; }
    }
}
