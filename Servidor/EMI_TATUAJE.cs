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
    
    public partial class EMI_TATUAJE
    {
        public int ID_EMI { get; set; }
        public short ID_EMI_CONS { get; set; }
        public Nullable<short> ANTISOCIAL_AI { get; set; }
        public Nullable<short> ANTISOCIAL_I { get; set; }
        public Nullable<short> EROTICO_AI { get; set; }
        public Nullable<short> EROTICO_I { get; set; }
        public Nullable<short> RELIGIOSO_AI { get; set; }
        public Nullable<short> RELIGIOSO_I { get; set; }
        public Nullable<short> IDENTIFICACION_AI { get; set; }
        public Nullable<short> IDENTIFICACION_I { get; set; }
        public Nullable<short> DECORATIVO_AI { get; set; }
        public Nullable<short> DECORATIVO_I { get; set; }
        public Nullable<short> SENTIMENTAL_AI { get; set; }
        public Nullable<short> SENTIMENTAL_I { get; set; }
        public Nullable<short> TOTAL_TATUAJES { get; set; }
        public string DESCR { get; set; }
    
        public virtual EMI EMI { get; set; }
    }
}