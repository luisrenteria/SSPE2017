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
    
    public partial class PFF_ESTUDIO_PSICOLOGICO
    {
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public string NOMBRE { get; set; }
        public string SOBRENOMBRE { get; set; }
        public Nullable<short> EDAD { get; set; }
        public string DELITO { get; set; }
        public string ACTITUD { get; set; }
        public string EXAMEN_MENTAL { get; set; }
        public string PRUEBAS_APLICADAS { get; set; }
        public string NIVEL_INTELECTUAL { get; set; }
        public string CI { get; set; }
        public string INDICE_LESION_ORGANICA { get; set; }
        public string DINAM_PERSON_INGRESO { get; set; }
        public string DINAM_PERSON_ACTUAL { get; set; }
        public string RESULT_TRATAMIENTO { get; set; }
        public string REQ_CONT_TRATAMIENTO { get; set; }
        public string INTERNO { get; set; }
        public string EXTERNO { get; set; }
        public string ESPECIFIQUE { get; set; }
        public string PRONOSTICO_REINTEGRACION { get; set; }
        public string OPINION { get; set; }
        public string LUGAR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string DIRECTOR_DENTRO { get; set; }
        public string PSICOLOGO { get; set; }
    
        public virtual PERSONALIDAD_FUERO_FEDERAL PERSONALIDAD_FUERO_FEDERAL { get; set; }
    }
}
