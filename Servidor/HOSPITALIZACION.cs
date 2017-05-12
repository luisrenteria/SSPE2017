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
    
    public partial class HOSPITALIZACION
    {
        public HOSPITALIZACION()
        {
            this.LIQUIDO_HOJA_CTRL_CONCEN = new HashSet<LIQUIDO_HOJA_CTRL_CONCEN>();
            this.LIQUIDO_HOJA_CTRL = new HashSet<LIQUIDO_HOJA_CTRL>();
            this.ATENCION_MEDICA = new HashSet<ATENCION_MEDICA>();
            this.HOJA_ENFERMERIA = new HashSet<HOJA_ENFERMERIA>();
        }
    
        public decimal ID_HOSPITA { get; set; }
        public Nullable<short> ID_CENTRO { get; set; }
        public Nullable<int> INGRESO_MEDICO { get; set; }
        public Nullable<System.DateTime> INGRESO_FEC { get; set; }
        public Nullable<decimal> ID_INGHOSTIP { get; set; }
        public Nullable<int> ID_ATENCION_MEDICA { get; set; }
        public Nullable<int> ALTA_MEDICO { get; set; }
        public Nullable<System.DateTime> ALTA_FEC { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> ID_HOSEST { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<short> ID_CAMA_HOSPITAL { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual CAMA_HOSPITAL CAMA_HOSPITAL { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual EMPLEADO EMPLEADO1 { get; set; }
        public virtual HOSPITALIZACION_INGRESO_TIPO HOSPITALIZACION_INGRESO_TIPO { get; set; }
        public virtual HOSPITALIZACION_ESTATUS HOSPITALIZACION_ESTATUS { get; set; }
        public virtual NOTA_MEDICA NOTA_MEDICA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<LIQUIDO_HOJA_CTRL_CONCEN> LIQUIDO_HOJA_CTRL_CONCEN { get; set; }
        public virtual ICollection<LIQUIDO_HOJA_CTRL> LIQUIDO_HOJA_CTRL { get; set; }
        public virtual ICollection<ATENCION_MEDICA> ATENCION_MEDICA { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA> HOJA_ENFERMERIA { get; set; }
        public virtual NOTA_EGRESO NOTA_EGRESO { get; set; }
    }
}
