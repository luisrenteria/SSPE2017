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
    
    public partial class HOJA_CONTROL_ENFERMERIA
    {
        public short ID_CENTRO_UBI { get; set; }
        public decimal ID_HOJACTRLEN { get; set; }
        public decimal ID_HOJAENF { get; set; }
        public decimal ID_HOSPITA { get; set; }
        public Nullable<decimal> ID_LIQHORA { get; set; }
        public Nullable<decimal> ID_LIQ { get; set; }
        public string ID_USUARIO { get; set; }
        public string OTRO_LIQUIDO { get; set; }
        public Nullable<short> CANT { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
    
        public virtual LIQUIDO LIQUIDO { get; set; }
        public virtual LIQUIDO_HORA LIQUIDO_HORA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual HOJA_ENFERMERIA HOJA_ENFERMERIA { get; set; }
    }
}
