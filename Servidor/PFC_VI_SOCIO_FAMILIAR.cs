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
    
    public partial class PFC_VI_SOCIO_FAMILIAR
    {
        public PFC_VI_SOCIO_FAMILIAR()
        {
            this.PFC_VI_COMUNICACION = new HashSet<PFC_VI_COMUNICACION>();
            this.PFC_VI_GRUPO = new HashSet<PFC_VI_GRUPO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public string P21_FAMILIA_PRIMARIA { get; set; }
        public string P22_FAMILIA_SECUNDARIA { get; set; }
        public string P3_TERCERA_EDAD { get; set; }
        public string P4_RECIBE_VISITA { get; set; }
        public Nullable<short> P4_PADRE { get; set; }
        public Nullable<short> P4_MADRE { get; set; }
        public Nullable<short> P4_ESPOSOA { get; set; }
        public Nullable<short> P4_HERMANOS { get; set; }
        public Nullable<short> P4_HIJOS { get; set; }
        public Nullable<short> P4_OTROS { get; set; }
        public string P4_OTROS_EPECIFICAR { get; set; }
        public string P4_FRECUENCIA { get; set; }
        public string P4_MOTIVO_NO_VISITA { get; set; }
        public string P5_COMUNICACION_TELEFONICA { get; set; }
        public string P5_NO_POR_QUE { get; set; }
        public string P6_APOYO_EXTERIOR { get; set; }
        public string P7_PLANES_INTERNO { get; set; }
        public string P7_VIVIRA { get; set; }
        public string P8_OFERTA_TRABAJO { get; set; }
        public string P8_OFERTA_ESPECIFICAR { get; set; }
        public string P9_AVAL_MORAL { get; set; }
        public string P9_AVAL_ESPECIFICAR { get; set; }
        public Nullable<short> P10_DICTAMEN { get; set; }
        public string P11_MOTIVACION_DICTAMEN { get; set; }
        public Nullable<System.DateTime> ESTUDIO_FEC { get; set; }
        public string COORDINADOR { get; set; }
        public string ELABORO { get; set; }
    
        public virtual PERSONALIDAD_FUERO_COMUN PERSONALIDAD_FUERO_COMUN { get; set; }
        public virtual ICollection<PFC_VI_COMUNICACION> PFC_VI_COMUNICACION { get; set; }
        public virtual ICollection<PFC_VI_GRUPO> PFC_VI_GRUPO { get; set; }
    }
}
