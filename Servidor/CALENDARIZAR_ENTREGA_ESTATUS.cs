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
    
    public partial class CALENDARIZAR_ENTREGA_ESTATUS
    {
        public CALENDARIZAR_ENTREGA_ESTATUS()
        {
            this.CALENDARIZAR_ENTREGA = new HashSet<CALENDARIZAR_ENTREGA>();
        }
    
        public string ID_CE_ESTATUS { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<CALENDARIZAR_ENTREGA> CALENDARIZAR_ENTREGA { get; set; }
    }
}