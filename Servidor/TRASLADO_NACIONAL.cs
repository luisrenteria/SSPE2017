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
    
    public partial class TRASLADO_NACIONAL
    {
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public Nullable<short> ID_PELIGROSIDAD { get; set; }
        public string ADICCION_TOXICOS { get; set; }
        public string CUALES { get; set; }
        public string CONTINUAR_PSICOLOGICO { get; set; }
        public string CONTINUAR_EDUCATIVO { get; set; }
        public string CONTINUAR_LABORAL { get; set; }
        public string CONTINUAR_OTROS { get; set; }
        public string OTROS_ASPECTOS_OPINION { get; set; }
        public string COORDINADOR_CRIMINOLOGIA { get; set; }
        public string ELABORO { get; set; }
        public string DIRECTOR_CERESO { get; set; }
        public Nullable<System.DateTime> ESTUDIO_FEC { get; set; }
    
        public virtual PFC_V_PELIGROSIDAD PFC_V_PELIGROSIDAD { get; set; }
        public virtual PERSONALIDAD PERSONALIDAD { get; set; }
    }
}