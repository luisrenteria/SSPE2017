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
    
    public partial class FRECUENCIA
    {
        public FRECUENCIA()
        {
            this.EMI_FACTORES_SOCIO_FAMILIARES = new HashSet<EMI_FACTORES_SOCIO_FAMILIARES>();
            this.EMI_FACTORES_SOCIO_FAMILIARES1 = new HashSet<EMI_FACTORES_SOCIO_FAMILIARES>();
        }
    
        public short ID_FRECUENCIA { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<EMI_FACTORES_SOCIO_FAMILIARES> EMI_FACTORES_SOCIO_FAMILIARES { get; set; }
        public virtual ICollection<EMI_FACTORES_SOCIO_FAMILIARES> EMI_FACTORES_SOCIO_FAMILIARES1 { get; set; }
    }
}
