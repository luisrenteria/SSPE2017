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
    
    public partial class TIPO_RELACION
    {
        public TIPO_RELACION()
        {
            this.EMI_ANTECEDENTE_FAMILIAR_DROGA = new HashSet<EMI_ANTECEDENTE_FAMILIAR_DROGA>();
            this.EMI_ANTECEDENTE_FAM_CON_DEL = new HashSet<EMI_ANTECEDENTE_FAM_CON_DEL>();
        }
    
        public short ID_RELACION { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<EMI_ANTECEDENTE_FAMILIAR_DROGA> EMI_ANTECEDENTE_FAMILIAR_DROGA { get; set; }
        public virtual ICollection<EMI_ANTECEDENTE_FAM_CON_DEL> EMI_ANTECEDENTE_FAM_CON_DEL { get; set; }
    }
}
