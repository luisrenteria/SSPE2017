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
    
    public partial class EDUCACION_CERTIFICADO
    {
        public EDUCACION_CERTIFICADO()
        {
            this.EMI_FICHA_IDENTIFICACION = new HashSet<EMI_FICHA_IDENTIFICACION>();
        }
    
        public short ID_CERTIFICADO { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<EMI_FICHA_IDENTIFICACION> EMI_FICHA_IDENTIFICACION { get; set; }
    }
}