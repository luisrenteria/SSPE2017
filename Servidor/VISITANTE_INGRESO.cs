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
    
    public partial class VISITANTE_INGRESO
    {
        public VISITANTE_INGRESO()
        {
            this.ACOMPANANTE = new HashSet<ACOMPANANTE>();
            this.ACOMPANANTE1 = new HashSet<ACOMPANANTE>();
            this.VISITA_DOCUMENTO = new HashSet<VISITA_DOCUMENTO>();
            this.VISITANTE_INGRESO_PASE = new HashSet<VISITANTE_INGRESO_PASE>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public int ID_PERSONA { get; set; }
        public Nullable<short> ID_TIPO_REFERENCIA { get; set; }
        public string EMISION_GAFETE { get; set; }
        public Nullable<short> ID_ESTATUS_VISITA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<System.DateTime> FEC_ALTA { get; set; }
        public Nullable<System.DateTime> FEC_ULTIMA_MOD { get; set; }
        public string ESTATUS_MOTIVO { get; set; }
        public Nullable<short> ID_TIPO_VISITANTE { get; set; }
        public string ACCESO_UNICO { get; set; }
        public Nullable<System.DateTime> INICIO_REGISTRO { get; set; }
        public Nullable<System.DateTime> FIN_REGISTRO { get; set; }
        public string ID_USUARIO { get; set; }
    
        public virtual ICollection<ACOMPANANTE> ACOMPANANTE { get; set; }
        public virtual ICollection<ACOMPANANTE> ACOMPANANTE1 { get; set; }
        public virtual ESTATUS_VISITA ESTATUS_VISITA { get; set; }
        public virtual TIPO_REFERENCIA TIPO_REFERENCIA { get; set; }
        public virtual TIPO_VISITANTE TIPO_VISITANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<VISITA_DOCUMENTO> VISITA_DOCUMENTO { get; set; }
        public virtual VISITANTE VISITANTE { get; set; }
        public virtual ICollection<VISITANTE_INGRESO_PASE> VISITANTE_INGRESO_PASE { get; set; }
        public virtual INGRESO INGRESO { get; set; }
    }
}
