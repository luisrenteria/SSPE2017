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
    
    public partial class EMI_CLAS_CRIMINOLOGICA
    {
        public int ID_EMI { get; set; }
        public short ID_EMI_CONS { get; set; }
        public Nullable<short> ID_CLAS { get; set; }
        public Nullable<short> ID_CRIMENO { get; set; }
        public Nullable<System.DateTime> FEC_CAPTURA { get; set; }
    
        public virtual CLASIFICACION_CRIMINOLOGICA CLASIFICACION_CRIMINOLOGICA { get; set; }
        public virtual PERTENECE_CRIMEN_ORG PERTENECE_CRIMEN_ORG { get; set; }
        public virtual EMI EMI { get; set; }
    }
}
