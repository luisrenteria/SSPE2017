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
    
    public partial class ATENCION_INGRESO
    {
        public int ID_ATENCION { get; set; }
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public Nullable<System.DateTime> REGISTRO_FEC { get; set; }
        public short ESTATUS { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual ATENCION_SOLICITUD ATENCION_SOLICITUD { get; set; }
        public virtual INGRESO INGRESO { get; set; }
    }
}
