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
    
    public partial class INGRESO_BIOMETRICO
    {
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_TIPO_BIOMETRICO { get; set; }
        public byte[] BIOMETRICO { get; set; }
        public short ID_FORMATO { get; set; }
    
        public virtual BIOMETRICO_TIPO BIOMETRICO_TIPO { get; set; }
        public virtual INGRESO INGRESO { get; set; }
    }
}
