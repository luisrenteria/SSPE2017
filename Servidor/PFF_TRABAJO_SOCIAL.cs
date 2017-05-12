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
    
    public partial class PFF_TRABAJO_SOCIAL
    {
        public PFF_TRABAJO_SOCIAL()
        {
            this.PFF_GRUPO_FAMILIAR = new HashSet<PFF_GRUPO_FAMILIAR>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<short> DIALECTO { get; set; }
        public string LUGAR_NAC { get; set; }
        public Nullable<System.DateTime> FECHA_NAC { get; set; }
        public Nullable<short> ESCOLARIDAD_CENTRO { get; set; }
        public Nullable<short> ESCOLARIDAD_ACTUAL { get; set; }
        public Nullable<short> EDO_CIVIL { get; set; }
        public Nullable<short> OCUPACION_ANT { get; set; }
        public string DOMICILIO { get; set; }
        public string ECO_FP_ZONA { get; set; }
        public string ECO_FP_RESPONSABLE { get; set; }
        public Nullable<int> ECO_FP_TOTAL_INGRESOS_MEN { get; set; }
        public Nullable<int> ECO_FP_TOTAL_EGRESOS_MEN { get; set; }
        public string ECO_FP_COOPERA_ACTUALMENTE { get; set; }
        public string ECO_FP_FONDOS_AHORRO { get; set; }
        public string CARACT_FP_GRUPO { get; set; }
        public string CARACT_FP_RELAC_INTERFAM { get; set; }
        public string CARACT_FP_VIOLENCIA_FAM { get; set; }
        public string CARACT_FP_VIOLENCIA_FAM_ESPEFI { get; set; }
        public string CARACT_FP_NIVEL_SOCIO_CULTURAL { get; set; }
        public string CARACT_FP_ANTECE_PENALES_ADIC { get; set; }
        public string CARACT_FP_ANTECEDENTES_PENALES { get; set; }
        public string CARACT_FP_CONCEPTO { get; set; }
        public string CARACT_FS_HIJOS_ANT { get; set; }
        public string CARACT_FS_GRUPO { get; set; }
        public string CARACT_FS_RELACIONES_INTERFAM { get; set; }
        public string CARACT_FS_VIOLENCIA_INTRAFAM { get; set; }
        public string CARACT_FS_VIOLENCIA_INTRAFAM_E { get; set; }
        public string CARACT_FS_NIVEL_SOCIO_CULTURAL { get; set; }
        public Nullable<short> CARACT_FS_VIVIEN_NUM_HABITACIO { get; set; }
        public string CARACT_FS_VIVIEN_DESCRIPCION { get; set; }
        public string CARACT_FS_VIVIEN_TRANSPORTE { get; set; }
        public string CARACT_FS_VIVIEN_MOBILIARIO { get; set; }
        public string CARACT_FS_ZONA { get; set; }
        public string CARACT_FS_RELACION_MEDIO_EXT { get; set; }
        public string CARACT_FS_PROBLEMAS_CONDUCTA { get; set; }
        public string CARACT_FS_PROBLEMAS_CONDUCTA_E { get; set; }
        public string NUM_PAREJAS_ESTABLE { get; set; }
        public string TRABAJO_DESEMP_ANTES { get; set; }
        public string TIEMPO_LABORAR { get; set; }
        public Nullable<int> SUELDO_PERCIBIDO { get; set; }
        public string APORTACIONES_FAM { get; set; }
        public string DISTRIBUCION_GASTO_FAM { get; set; }
        public string ALIMENTACION_FAM { get; set; }
        public string SERVICIOS_PUBLICOS { get; set; }
        public string OFERTA_TRABAJO { get; set; }
        public string OFERTA_TRABAJO_CONSISTE { get; set; }
        public string APOYO_FAM_OTROS { get; set; }
        public string VISITA_FAMILIARES { get; set; }
        public Nullable<short> VISTA_PARENTESCO { get; set; }
        public string VISITAS_OTROS { get; set; }
        public string VISITA_OTROS_QUIIEN { get; set; }
        public string OPINION_INTERNAMIENTO { get; set; }
        public string INFLUENCIADO_ESTANCIA_PRISION { get; set; }
        public string DIAG_SOCIAL_PRONOS { get; set; }
        public string OPINION_CONCESION_BENEFICIOS { get; set; }
        public string LUGAR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string DIRECTOR_CENTRO { get; set; }
        public string TRABAJADORA_SOCIAL { get; set; }
        public string RADICAN_ESTADO { get; set; }
        public string VISITA_FRECUENCIA { get; set; }
        public string AVAL_MORAL { get; set; }
        public string AVAL_MORAL_PARENTESCO { get; set; }
        public string EXTERNADO_VIVIR_NOMBRE { get; set; }
        public Nullable<short> EXTERNADO_PARENTESCO { get; set; }
        public string EXTERNADO_CALLE { get; set; }
        public string EXTERNADO_NUMERO { get; set; }
        public Nullable<int> EXTERNADO_COLONIA { get; set; }
        public string EXTERNADO_CP { get; set; }
        public Nullable<short> EXTERNADO_CIUDAD { get; set; }
        public Nullable<short> EXTERNADO_MUNICIPIO { get; set; }
        public Nullable<short> EXTERNADO_ENTIDAD { get; set; }
    
        public virtual COLONIA COLONIA { get; set; }
        public virtual DIALECTO DIALECTO1 { get; set; }
        public virtual ESCOLARIDAD ESCOLARIDAD { get; set; }
        public virtual ESCOLARIDAD ESCOLARIDAD1 { get; set; }
        public virtual MUNICIPIO MUNICIPIO { get; set; }
        public virtual MUNICIPIO MUNICIPIO1 { get; set; }
        public virtual OCUPACION OCUPACION { get; set; }
        public virtual PERSONALIDAD_FUERO_FEDERAL PERSONALIDAD_FUERO_FEDERAL { get; set; }
        public virtual TIPO_REFERENCIA TIPO_REFERENCIA { get; set; }
        public virtual ICollection<PFF_GRUPO_FAMILIAR> PFF_GRUPO_FAMILIAR { get; set; }
    }
}
