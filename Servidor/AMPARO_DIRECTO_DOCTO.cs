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
    
    public partial class AMPARO_DIRECTO_DOCTO
    {
        public short ID_ANIO { get; set; }
        public short ID_CENTRO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_CAUSA_PENAL { get; set; }
        public short ID_AMPARO_DIRECTO { get; set; }
        public short ID_DOCTO { get; set; }
        public string DESCR { get; set; }
        public Nullable<System.DateTime> DIGITALIZACION_FEC { get; set; }
        public byte[] DOCUMENTO { get; set; }
    
        public virtual AMPARO_DIRECTO AMPARO_DIRECTO { get; set; }
    }
}
