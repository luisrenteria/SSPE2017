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
    
    public partial class NOTIFICACION_TS
    {
        public NOTIFICACION_TS()
        {
            this.DIAGNOSTICO_MEDICO_NOTIFICA = new HashSet<DIAGNOSTICO_MEDICO_NOTIFICA>();
            this.NOTIFICACION_TS1 = new HashSet<NOTIFICACION_TS>();
        }
    
        public decimal ID_NOTIFICACION_TS { get; set; }
        public Nullable<short> ID_CENTRO { get; set; }
        public Nullable<short> ID_ANIO { get; set; }
        public Nullable<int> ID_IMPUTADO { get; set; }
        public Nullable<decimal> ID_CANALIZACION_TS { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<decimal> ID_RIESGOS { get; set; }
        public Nullable<decimal> ID_CARACTER { get; set; }
        public Nullable<decimal> ID_DIAGNOSTICO { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public string OTROS_RIESGOS { get; set; }
        public string MENSAJE { get; set; }
        public Nullable<decimal> ID_NOTIFICAION_TIPO { get; set; }
        public Nullable<short> ID_INGRESO { get; set; }
        public Nullable<int> FOLIO_NOTIF { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual CARACTER_NOTIFICACION_TS CARACTER_NOTIFICACION_TS { get; set; }
        public virtual CENTRO CENTRO { get; set; }
        public virtual ICollection<DIAGNOSTICO_MEDICO_NOTIFICA> DIAGNOSTICO_MEDICO_NOTIFICA { get; set; }
        public virtual DIAGNOSTICO_NOTIFICA_TS_TIPO DIAGNOSTICO_NOTIFICA_TS_TIPO { get; set; }
        public virtual ICollection<NOTIFICACION_TS> NOTIFICACION_TS1 { get; set; }
        public virtual NOTIFICACION_TS NOTIFICACION_TS2 { get; set; }
        public virtual NOTIFICACION_TS_TIPO NOTIFICACION_TS_TIPO { get; set; }
        public virtual RIESGO_NOTIFICACION_TS RIESGO_NOTIFICACION_TS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual INGRESO INGRESO { get; set; }
        public virtual IMPUTADO IMPUTADO { get; set; }
    }
}
