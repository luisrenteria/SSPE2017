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
    
    public partial class AMPARO_DIRECTO
    {
        public AMPARO_DIRECTO()
        {
            this.AMPARO_DIRECTO_DOCTO = new HashSet<AMPARO_DIRECTO_DOCTO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_CAUSA_PENAL { get; set; }
        public short ID_AMPARO_DIRECTO { get; set; }
        public Nullable<System.DateTime> DOCUMENTO_FEC { get; set; }
        public Nullable<System.DateTime> NOTIFICACION_FEC { get; set; }
        public Nullable<System.DateTime> SUSPENSION_FEC { get; set; }
        public string OFICIO_NUM { get; set; }
        public Nullable<short> SUSPENSION_AUT_INFORMA { get; set; }
        public Nullable<System.DateTime> SENTENCIA_FEC { get; set; }
        public Nullable<short> ID_SEN_AMP_RESULTADO { get; set; }
        public Nullable<short> SENTENCIA_AMP_AUTORIDAD { get; set; }
        public string AMPARO_NUM { get; set; }
        public Nullable<System.DateTime> RESUELVE_DOCUMENTO_FEC { get; set; }
        public Nullable<System.DateTime> RESUELVE_SENTENCIA_FEC { get; set; }
        public string RESUELVE_OFICIO_NUM { get; set; }
        public Nullable<short> AUTORIDAD_NOTIFICA { get; set; }
        public Nullable<short> AUTORIDAD_PRONUNCIA_SENTENCIA { get; set; }
        public Nullable<short> ID_SENTENCIA { get; set; }
    
        public virtual ICollection<AMPARO_DIRECTO_DOCTO> AMPARO_DIRECTO_DOCTO { get; set; }
        public virtual AMPARO_DIRECTO_SENTENCIA AMPARO_DIRECTO_SENTENCIA { get; set; }
        public virtual CAUSA_PENAL CAUSA_PENAL { get; set; }
        public virtual JUZGADO JUZGADO { get; set; }
        public virtual JUZGADO JUZGADO1 { get; set; }
        public virtual JUZGADO JUZGADO2 { get; set; }
        public virtual JUZGADO JUZGADO3 { get; set; }
        public virtual INGRESO INGRESO { get; set; }
    }
}