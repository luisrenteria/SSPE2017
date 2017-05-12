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
    
    public partial class AMPARO_INCIDENTE
    {
        public AMPARO_INCIDENTE()
        {
            this.AMPARO_INCIDENTE_DOCTO = new HashSet<AMPARO_INCIDENTE_DOCTO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_CAUSA_PENAL { get; set; }
        public short ID_AMPARO_INCIDENTE { get; set; }
        public string RESULTADO { get; set; }
        public Nullable<decimal> DIAS_REMISION { get; set; }
        public Nullable<System.DateTime> CAPTURA_FEC { get; set; }
        public Nullable<System.DateTime> DOCUMENTO_FEC { get; set; }
        public string OFICIO_NUM { get; set; }
        public Nullable<short> AUTORIDAD_NOTIFICA { get; set; }
        public Nullable<decimal> GARANTIA { get; set; }
        public Nullable<short> MODIFICA_PENA_ANIO { get; set; }
        public Nullable<short> MODIFICA_PENA_MES { get; set; }
        public Nullable<short> MODIFICA_PENA_DIA { get; set; }
        public Nullable<short> ID_AMP_INC_TIPO { get; set; }
        public Nullable<short> ID_SENTENCIA { get; set; }
    
        public virtual ICollection<AMPARO_INCIDENTE_DOCTO> AMPARO_INCIDENTE_DOCTO { get; set; }
        public virtual AMPARO_INCIDENTE_TIPO AMPARO_INCIDENTE_TIPO { get; set; }
        public virtual CAUSA_PENAL CAUSA_PENAL { get; set; }
        public virtual JUZGADO JUZGADO { get; set; }
    }
}