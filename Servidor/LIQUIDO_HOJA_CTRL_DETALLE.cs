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
    
    public partial class LIQUIDO_HOJA_CTRL_DETALLE
    {
        public decimal ID_LIQHOJACTRL { get; set; }
        public decimal ID_HOSPITA { get; set; }
        public short ID_CENTRO_UBI { get; set; }
        public decimal ID_LIQ { get; set; }
        public Nullable<decimal> CANT { get; set; }
    
        public virtual LIQUIDO_HOJA_CTRL LIQUIDO_HOJA_CTRL { get; set; }
        public virtual LIQUIDO LIQUIDO { get; set; }
    }
}
