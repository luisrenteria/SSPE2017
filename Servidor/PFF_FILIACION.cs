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
    
    public partial class PFF_FILIACION
    {
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public short ID_MEDIA_FILIACION { get; set; }
        public short ID_TIPO_FILIACION { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual PFF_FICHA_IDENTIFICACION PFF_FICHA_IDENTIFICACION { get; set; }
        public virtual TIPO_FILIACION TIPO_FILIACION { get; set; }
    }
}
