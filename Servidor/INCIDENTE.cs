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
    
    public partial class INCIDENTE
    {
        public INCIDENTE()
        {
            this.SANCION = new HashSet<SANCION>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_INCIDENTE { get; set; }
        public Nullable<short> ID_INCIDENTE_TIPO { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public string MOTIVO { get; set; }
        public string ESTATUS { get; set; }
        public Nullable<System.DateTime> AUTORIZACION_FEC { get; set; }
        public Nullable<int> ID_ATENCION_MEDICA { get; set; }
        public Nullable<short> ID_CENTRO_UBI { get; set; }
    
        public virtual ATENCION_MEDICA ATENCION_MEDICA { get; set; }
        public virtual INGRESO INGRESO { get; set; }
        public virtual ICollection<SANCION> SANCION { get; set; }
        public virtual INCIDENTE_TIPO INCIDENTE_TIPO { get; set; }
    }
}