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
    
    public partial class DROGA_FRECUENCIA
    {
        public DROGA_FRECUENCIA()
        {
            this.EMI_USO_DROGA = new HashSet<EMI_USO_DROGA>();
            this.LIBERADO_SUSTANCIA = new HashSet<LIBERADO_SUSTANCIA>();
            this.PRS_DROGA = new HashSet<PRS_DROGA>();
        }
    
        public short ID_FRECUENCIA { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<EMI_USO_DROGA> EMI_USO_DROGA { get; set; }
        public virtual ICollection<LIBERADO_SUSTANCIA> LIBERADO_SUSTANCIA { get; set; }
        public virtual ICollection<PRS_DROGA> PRS_DROGA { get; set; }
    }
}