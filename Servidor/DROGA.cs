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
    
    public partial class DROGA
    {
        public DROGA()
        {
            this.EMI_ANTECEDENTE_FAMILIAR_DROGA = new HashSet<EMI_ANTECEDENTE_FAMILIAR_DROGA>();
            this.EMI_USO_DROGA = new HashSet<EMI_USO_DROGA>();
            this.DECOMISO_OBJETO = new HashSet<DECOMISO_OBJETO>();
            this.LIBERADO_SUSTANCIA = new HashSet<LIBERADO_SUSTANCIA>();
            this.PRS_DROGA = new HashSet<PRS_DROGA>();
            this.PFF_SUSTANCIA_TOXICA = new HashSet<PFF_SUSTANCIA_TOXICA>();
        }
    
        public short ID_DROGA { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<EMI_ANTECEDENTE_FAMILIAR_DROGA> EMI_ANTECEDENTE_FAMILIAR_DROGA { get; set; }
        public virtual ICollection<EMI_USO_DROGA> EMI_USO_DROGA { get; set; }
        public virtual ICollection<DECOMISO_OBJETO> DECOMISO_OBJETO { get; set; }
        public virtual ICollection<LIBERADO_SUSTANCIA> LIBERADO_SUSTANCIA { get; set; }
        public virtual ICollection<PRS_DROGA> PRS_DROGA { get; set; }
        public virtual ICollection<PFF_SUSTANCIA_TOXICA> PFF_SUSTANCIA_TOXICA { get; set; }
    }
}
