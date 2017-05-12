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
    
    public partial class HOJA_ENFERMERIA
    {
        public HOJA_ENFERMERIA()
        {
            this.HOJA_CONTROL_ENFERMERIA = new HashSet<HOJA_CONTROL_ENFERMERIA>();
            this.HOJA_ENFERMERIA_MEDICAMENTO = new HashSet<HOJA_ENFERMERIA_MEDICAMENTO>();
            this.HOJA_ENFERMERIA_ULCERA = new HashSet<HOJA_ENFERMERIA_ULCERA>();
            this.HOJA_ENFERMERIA_LECTURA = new HashSet<HOJA_ENFERMERIA_LECTURA>();
            this.HOJA_ENFERMERIA_SOLUCION = new HashSet<HOJA_ENFERMERIA_SOLUCION>();
            this.HOJA_ENFERMERIA_CATETER = new HashSet<HOJA_ENFERMERIA_CATETER>();
            this.HOJA_ENFERMERIA_SONDA_GASOGAS = new HashSet<HOJA_ENFERMERIA_SONDA_GASOGAS>();
        }
    
        public short ID_CENTRO_UBI { get; set; }
        public decimal ID_HOJAENF { get; set; }
        public decimal ID_HOSPITA { get; set; }
        public Nullable<decimal> ID_LIQTURNO { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<System.DateTime> FECHA_HOJA { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
        public Nullable<int> CONCENTRADO_INGRESO { get; set; }
        public Nullable<int> CONCENTRADO_EGRESO { get; set; }
        public string OBSERVACION { get; set; }
        public string ESTATUS { get; set; }
        public string RX { get; set; }
        public string LABORATORIO { get; set; }
    
        public virtual ICollection<HOJA_CONTROL_ENFERMERIA> HOJA_CONTROL_ENFERMERIA { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_MEDICAMENTO> HOJA_ENFERMERIA_MEDICAMENTO { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_ULCERA> HOJA_ENFERMERIA_ULCERA { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_LECTURA> HOJA_ENFERMERIA_LECTURA { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_SOLUCION> HOJA_ENFERMERIA_SOLUCION { get; set; }
        public virtual HOSPITALIZACION HOSPITALIZACION { get; set; }
        public virtual LIQUIDO_TURNO LIQUIDO_TURNO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_CATETER> HOJA_ENFERMERIA_CATETER { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_SONDA_GASOGAS> HOJA_ENFERMERIA_SONDA_GASOGAS { get; set; }
    }
}
