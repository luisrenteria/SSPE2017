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
    
    public partial class ACTUARIO_LISTA
    {
        public ACTUARIO_LISTA()
        {
            this.ACTUARIO_INGRESO = new HashSet<ACTUARIO_INGRESO>();
        }
    
        public int ID_LISTA { get; set; }
        public int ID_ABOGADO { get; set; }
        public Nullable<System.DateTime> CAPTURA_FEC { get; set; }
    
        public virtual ICollection<ACTUARIO_INGRESO> ACTUARIO_INGRESO { get; set; }
        public virtual ABOGADO ABOGADO { get; set; }
    }
}