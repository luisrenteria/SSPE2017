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
    
    public partial class MOTIVO_EGRESO_MEDICO
    {
        public MOTIVO_EGRESO_MEDICO()
        {
            this.NOTA_EGRESO = new HashSet<NOTA_EGRESO>();
        }
    
        public decimal ID_MOEGMED { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<NOTA_EGRESO> NOTA_EGRESO { get; set; }
    }
}
