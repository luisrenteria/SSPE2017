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
    
    public partial class LUGAR_CUMPLIMIENTO
    {
        public LUGAR_CUMPLIMIENTO()
        {
            this.MEDIDA_PRESENTACION = new HashSet<MEDIDA_PRESENTACION>();
        }
    
        public decimal ID_LUGCUM { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<MEDIDA_PRESENTACION> MEDIDA_PRESENTACION { get; set; }
    }
}
