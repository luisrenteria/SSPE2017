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
    
    public partial class LIQUIDO_HOJA_CTRL
    {
        public LIQUIDO_HOJA_CTRL()
        {
            this.LIQUIDO_HOJA_CTRL_DETALLE = new HashSet<LIQUIDO_HOJA_CTRL_DETALLE>();
        }
    
        public decimal ID_LIQHOJACTRL { get; set; }
        public decimal ID_HOSPITA { get; set; }
        public short ID_CENTRO_UBI { get; set; }
        public Nullable<decimal> ID_LIQHORA { get; set; }
        public string ID_USUARIO__REGISTRO { get; set; }
        public string TEMPERATURA { get; set; }
        public string FRECUENCIA_CARDIACA { get; set; }
        public string FRECUENCIA_RESPIRATORIA { get; set; }
        public string TENSION_ARTERIAL { get; set; }
        public string GLUCEMIA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
    
        public virtual HOSPITALIZACION HOSPITALIZACION { get; set; }
        public virtual LIQUIDO_HORA LIQUIDO_HORA { get; set; }
        public virtual ICollection<LIQUIDO_HOJA_CTRL_DETALLE> LIQUIDO_HOJA_CTRL_DETALLE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
