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
    
    public partial class EMISOR
    {
        public EMISOR()
        {
            this.EMI_FICHA_IDENTIFICACION = new HashSet<EMI_FICHA_IDENTIFICACION>();
            this.EMI_INGRESO_ANTERIOR = new HashSet<EMI_INGRESO_ANTERIOR>();
            this.CENTRO = new HashSet<CENTRO>();
            this.EMI_ANTECEDENTE_FAM_CON_DEL = new HashSet<EMI_ANTECEDENTE_FAM_CON_DEL>();
            this.TRASLADO = new HashSet<TRASLADO>();
            this.TRASLADO1 = new HashSet<TRASLADO>();
        }
    
        public int ID_EMISOR { get; set; }
        public string DESCR { get; set; }
        public Nullable<short> PM { get; set; }
    
        public virtual ICollection<EMI_FICHA_IDENTIFICACION> EMI_FICHA_IDENTIFICACION { get; set; }
        public virtual ICollection<EMI_INGRESO_ANTERIOR> EMI_INGRESO_ANTERIOR { get; set; }
        public virtual ICollection<CENTRO> CENTRO { get; set; }
        public virtual ICollection<EMI_ANTECEDENTE_FAM_CON_DEL> EMI_ANTECEDENTE_FAM_CON_DEL { get; set; }
        public virtual ICollection<TRASLADO> TRASLADO { get; set; }
        public virtual ICollection<TRASLADO> TRASLADO1 { get; set; }
    }
}