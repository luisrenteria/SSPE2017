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
    
    public partial class IMPUTADO
    {
        public IMPUTADO()
        {
            this.ALIAS = new HashSet<ALIAS>();
            this.APODO = new HashSet<APODO>();
            this.EMI_IMPUTADO = new HashSet<EMI_IMPUTADO>();
            this.FAMILIAR_RESPONSABLE = new HashSet<FAMILIAR_RESPONSABLE>();
            this.IMPUTADO_PADRES = new HashSet<IMPUTADO_PADRES>();
            this.IMPUTADO_FILIACION = new HashSet<IMPUTADO_FILIACION>();
            this.IMPUTADO_BIOMETRICO = new HashSet<IMPUTADO_BIOMETRICO>();
            this.IMPUTADO_FORMATO = new HashSet<IMPUTADO_FORMATO>();
            this.IMPUTADO_PANDILLA = new HashSet<IMPUTADO_PANDILLA>();
            this.INGRESO = new HashSet<INGRESO>();
            this.NOTIFICACION_TS = new HashSet<NOTIFICACION_TS>();
            this.PRS_ENTREVISTA_INICIAL = new HashSet<PRS_ENTREVISTA_INICIAL>();
            this.PRS_FICHA_IDEN = new HashSet<PRS_FICHA_IDEN>();
            this.PRS_REPORTE_PSICOLOGICO = new HashSet<PRS_REPORTE_PSICOLOGICO>();
            this.PRS_VISITA_DOMICILIARIA = new HashSet<PRS_VISITA_DOMICILIARIA>();
            this.RELACION_PERSONAL_INTERNO = new HashSet<RELACION_PERSONAL_INTERNO>();
            this.SENAS_PARTICULARES = new HashSet<SENAS_PARTICULARES>();
            this.PROCESO_LIBERTAD = new HashSet<PROCESO_LIBERTAD>();
            this.HISTORICO_DOCUMENTOS = new HashSet<HISTORICO_DOCUMENTOS>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string NOMBRE { get; set; }
        public string SEXO { get; set; }
        public Nullable<short> ID_ETNIA { get; set; }
        public Nullable<short> ID_NACIONALIDAD { get; set; }
        public Nullable<short> NACIMIENTO_PAIS { get; set; }
        public Nullable<short> NACIMIENTO_ESTADO { get; set; }
        public Nullable<short> NACIMIENTO_MUNICIPIO { get; set; }
        public Nullable<System.DateTime> NACIMIENTO_FECHA { get; set; }
        public string NACIMIENTO_LUGAR { get; set; }
        public string PATERNO_MADRE { get; set; }
        public string MATERNO_MADRE { get; set; }
        public string NOMBRE_MADRE { get; set; }
        public string PATERNO_PADRE { get; set; }
        public string MATERNO_PADRE { get; set; }
        public string NOMBRE_PADRE { get; set; }
        public string TABAJADOR_CERESO { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string IFE { get; set; }
        public string NIP { get; set; }
        public Nullable<System.DateTime> BI_FECALTA { get; set; }
        public string BI_USER { get; set; }
        public string TELORIGINAL { get; set; }
        public string SPATERNO { get; set; }
        public string SMATERNO { get; set; }
        public string SNOMBRE { get; set; }
        public Nullable<short> ID_IDIOMA { get; set; }
        public Nullable<short> ID_DIALECTO { get; set; }
        public string TRADUCTOR { get; set; }
    
        public virtual ICollection<ALIAS> ALIAS { get; set; }
        public virtual ICollection<APODO> APODO { get; set; }
        public virtual CENTRO CENTRO { get; set; }
        public virtual DIALECTO DIALECTO { get; set; }
        public virtual ICollection<EMI_IMPUTADO> EMI_IMPUTADO { get; set; }
        public virtual ETNIA ETNIA { get; set; }
        public virtual ICollection<FAMILIAR_RESPONSABLE> FAMILIAR_RESPONSABLE { get; set; }
        public virtual IDIOMA IDIOMA { get; set; }
        public virtual ICollection<IMPUTADO_PADRES> IMPUTADO_PADRES { get; set; }
        public virtual PAIS_NACIONALIDAD PAIS_NACIONALIDAD { get; set; }
        public virtual ICollection<IMPUTADO_FILIACION> IMPUTADO_FILIACION { get; set; }
        public virtual MUNICIPIO MUNICIPIO { get; set; }
        public virtual ICollection<IMPUTADO_BIOMETRICO> IMPUTADO_BIOMETRICO { get; set; }
        public virtual ICollection<IMPUTADO_FORMATO> IMPUTADO_FORMATO { get; set; }
        public virtual ICollection<IMPUTADO_PANDILLA> IMPUTADO_PANDILLA { get; set; }
        public virtual ICollection<INGRESO> INGRESO { get; set; }
        public virtual LIBERADO LIBERADO { get; set; }
        public virtual ICollection<NOTIFICACION_TS> NOTIFICACION_TS { get; set; }
        public virtual ICollection<PRS_ENTREVISTA_INICIAL> PRS_ENTREVISTA_INICIAL { get; set; }
        public virtual ICollection<PRS_FICHA_IDEN> PRS_FICHA_IDEN { get; set; }
        public virtual ICollection<PRS_REPORTE_PSICOLOGICO> PRS_REPORTE_PSICOLOGICO { get; set; }
        public virtual ICollection<PRS_VISITA_DOMICILIARIA> PRS_VISITA_DOMICILIARIA { get; set; }
        public virtual ICollection<RELACION_PERSONAL_INTERNO> RELACION_PERSONAL_INTERNO { get; set; }
        public virtual ICollection<SENAS_PARTICULARES> SENAS_PARTICULARES { get; set; }
        public virtual ICollection<PROCESO_LIBERTAD> PROCESO_LIBERTAD { get; set; }
        public virtual ICollection<HISTORICO_DOCUMENTOS> HISTORICO_DOCUMENTOS { get; set; }
    }
}
