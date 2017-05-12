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
    
    public partial class PFF_CAPACITACION
    {
        public PFF_CAPACITACION()
        {
            this.PFF_CAPACITACION_CURSO = new HashSet<PFF_CAPACITACION_CURSO>();
            this.PFF_DIAS_LABORADO = new HashSet<PFF_DIAS_LABORADO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public string NOMBRE { get; set; }
        public string SECCION { get; set; }
        public Nullable<short> OFICIO_ANTES_RECLUSION { get; set; }
        public Nullable<int> SALARIO_DEVENGABA_DETENCION { get; set; }
        public string ACTIVIDAD_PRODUC_ACTUAL { get; set; }
        public string ATIENDE_INDICACIONES { get; set; }
        public string SATISFACE_ACTIVIDAD { get; set; }
        public string DESCUIDADO_LABORES { get; set; }
        public string MOTIVO_TIEMPO_INTERRUP_ACT { get; set; }
        public string RECIBIO_CONSTANCIA { get; set; }
        public string NO_CURSOS_MOTIVO { get; set; }
        public string CAMBIO_ACTIVIDAD { get; set; }
        public string CAMBIO_ACTIVIDAD_POR_QUE { get; set; }
        public string HA_PROGRESADO_OFICIO { get; set; }
        public string ACTITUDES_DESEMPENO_ACT { get; set; }
        public string FONDO_AHORRO { get; set; }
        public string FONDO_AHORRO_COMPESACION_ACTUA { get; set; }
        public Nullable<int> A_TOTAL_DIAS_LABORADOS { get; set; }
        public Nullable<int> B_DIAS_LABORADOS_OTROS_CERESOS { get; set; }
        public Nullable<int> TOTAL_A_B { get; set; }
        public string CONCLUSIONES { get; set; }
        public string LUGAR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string DIRECTOR_CENTRO { get; set; }
        public string JEFE_SECC_INDUSTRIAL { get; set; }
    
        public virtual OCUPACION OCUPACION { get; set; }
        public virtual PERSONALIDAD_FUERO_FEDERAL PERSONALIDAD_FUERO_FEDERAL { get; set; }
        public virtual ICollection<PFF_CAPACITACION_CURSO> PFF_CAPACITACION_CURSO { get; set; }
        public virtual ICollection<PFF_DIAS_LABORADO> PFF_DIAS_LABORADO { get; set; }
    }
}