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
    
    public partial class DECOMISO_PERSONA
    {
        public int ID_DECOMISO { get; set; }
        public int ID_PERSONA { get; set; }
        public Nullable<short> ID_TIPO_PERSONA { get; set; }
        public string DATOS_DECOMISO { get; set; }
        public string OFICIAL_A_CARGO { get; set; }
    
        public virtual DECOMISO DECOMISO { get; set; }
        public virtual TIPO_PERSONA TIPO_PERSONA { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}
