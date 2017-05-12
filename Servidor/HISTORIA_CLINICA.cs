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
    
    public partial class HISTORIA_CLINICA
    {
        public HISTORIA_CLINICA()
        {
            this.GRUPO_VULNERABLE = new HashSet<GRUPO_VULNERABLE>();
            this.HISTORIA_CLINICA_FAMILIAR = new HashSet<HISTORIA_CLINICA_FAMILIAR>();
            this.HISTORIA_CLINICA_PATOLOGICOS = new HashSet<HISTORIA_CLINICA_PATOLOGICOS>();
            this.HISTORIA_CLINICA_DOCUMENTO = new HashSet<HISTORIA_CLINICA_DOCUMENTO>();
            this.HISTORIA_CLINICA_GINECO_OBSTRE = new HashSet<HISTORIA_CLINICA_GINECO_OBSTRE>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_CONSEC { get; set; }
        public Nullable<int> ID_RESPONSABLE { get; set; }
        public Nullable<System.DateTime> ESTUDIO_FEC { get; set; }
        public Nullable<short> AHF_HERMANOS_M { get; set; }
        public Nullable<short> AHF_HERMANOS_F { get; set; }
        public string AHF_NOMBRE { get; set; }
        public string APNP_NACIMIENTO { get; set; }
        public string APNP_ALIMENTACION { get; set; }
        public string APNP_HABITACION { get; set; }
        public string APNP_ALCOHOLISMO { get; set; }
        public string APNP_TABAQUISMO { get; set; }
        public string APNP_TOXICOMANIAS { get; set; }
        public Nullable<short> MU_MENARQUIA { get; set; }
        public string PADECIMIENTO_ACTUAL { get; set; }
        public string RESPIRATORIO { get; set; }
        public string RES_NOMBRE { get; set; }
        public string CARDIOVASCULAR { get; set; }
        public string DIGESTIVO { get; set; }
        public string URINARIO { get; set; }
        public string GENITAL_MUJERES { get; set; }
        public string GENITAL_HOMBRES { get; set; }
        public string ENDOCRINO { get; set; }
        public string MUSCULO_ESQUELETICO { get; set; }
        public string PAG3_NOMBRE { get; set; }
        public string HEMATICO_LINFACTICO { get; set; }
        public string NERVIOSO { get; set; }
        public string PIEL_ANEXOS { get; set; }
        public string SINTOMAS_GENERALES { get; set; }
        public string TERAPEUTICA_PREVIA { get; set; }
        public string EF_PESO { get; set; }
        public string EF_ESTATURA { get; set; }
        public string EF_CABEZA { get; set; }
        public string EF_CUELLO { get; set; }
        public string EF_TORAX { get; set; }
        public string PAG4_NOMBRE { get; set; }
        public string EF_ABDOMEN { get; set; }
        public string EF_RECTO { get; set; }
        public string EF_GENITALES { get; set; }
        public string EF_EXTREMIDADES { get; set; }
        public string EF_PRESION_ARTERIAL { get; set; }
        public string EF_PULSO { get; set; }
        public string EF_RESPIRACION { get; set; }
        public string EF_TEMPERATURA { get; set; }
        public string EF_RESULTADO_ANALISIS { get; set; }
        public string EF_RESULTADO_GABINETE { get; set; }
        public string EF_IMPRESION_DIAGNOSTICA { get; set; }
        public string PAG5_NOMBRE { get; set; }
        public Nullable<short> M65_ALTERACION_VISUAL { get; set; }
        public string M65_OTROS { get; set; }
        public string M65_ALTERACION_AUDITIVA { get; set; }
        public string M65_ALTERACION_OLFACION { get; set; }
        public string M65_ALTERACION_VISOMOTRIZ { get; set; }
        public Nullable<short> M65_TRAS_MEMORIA { get; set; }
        public Nullable<short> M65_TRAS_ATENCION { get; set; }
        public Nullable<short> M65_TRAS_COMPRENSION { get; set; }
        public Nullable<short> M65_TRAS_ORIENTACION { get; set; }
        public string M65_TRAS_DEMENCIAL { get; set; }
        public Nullable<short> M65_TRAS_ANIMO { get; set; }
        public Nullable<short> M65_PARTICIPACION { get; set; }
        public Nullable<short> CP_GRAVEDAD { get; set; }
        public Nullable<short> CP_ETAPA_EVOLUTIVA { get; set; }
        public Nullable<short> CP_REMISION { get; set; }
        public string CP_GRADO_AFECTACION { get; set; }
        public string CP_PRONOSTICO { get; set; }
        public Nullable<short> CP_CAPACIDAD_TRATAMIENTO { get; set; }
        public Nullable<short> CP_NIVEL_ATENCION { get; set; }
        public string CONCLUSIONES { get; set; }
        public string DOCTOR { get; set; }
        public string CEDULA_PROFESIONAL { get; set; }
        public Nullable<System.DateTime> ULTIMA_FEC { get; set; }
        public Nullable<short> DIRECTO { get; set; }
        public Nullable<short> POR_CONSTANCIAS_DOCUMENTALES { get; set; }
        public string APP_MEDICAMENTOS_ACTIVOS { get; set; }
        public string APNP_ALCOHOLISMO_OBSERV { get; set; }
        public string APNP_TABAQUISMO_OBSERV { get; set; }
        public string APNP_TOXICOMANIAS_OBSERV { get; set; }
        public string EF_DESCRIPCION { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<GRUPO_VULNERABLE> GRUPO_VULNERABLE { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_FAMILIAR> HISTORIA_CLINICA_FAMILIAR { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_PATOLOGICOS> HISTORIA_CLINICA_PATOLOGICOS { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_DOCUMENTO> HISTORIA_CLINICA_DOCUMENTO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual INGRESO INGRESO { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_GINECO_OBSTRE> HISTORIA_CLINICA_GINECO_OBSTRE { get; set; }
    }
}