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
    
    public partial class PFC_III_PSIQUIATRICO
    {
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_ESTUDIO { get; set; }
        public string A1_ASPECTO_FISICO { get; set; }
        public string B1_CONDUCTA_MOTORA { get; set; }
        public string C1_HABLA { get; set; }
        public string D1_ACTITUD { get; set; }
        public string A2_ESTADO_ANIMO { get; set; }
        public string B2_EXPRESION_AFECTIVA { get; set; }
        public string C2_ADECUACION { get; set; }
        public string A3_ALUCINACIONES { get; set; }
        public string B3_ILUSIONES { get; set; }
        public string C3_DESPERSONALIZACION { get; set; }
        public string D3_DESREALIZACION { get; set; }
        public string A4_CURSO { get; set; }
        public string B4_CONTINUIDAD { get; set; }
        public string C4_CONTENIDO { get; set; }
        public string D4_ABASTRACTO { get; set; }
        public string E4_CONCENTRACION { get; set; }
        public string P5_ORIENTACION { get; set; }
        public string P6_MEMORIA { get; set; }
        public string A7_BAJA_TOLERANCIA { get; set; }
        public string B7_EXPRESION { get; set; }
        public string C7_ADECUADA { get; set; }
        public string P8_CAPACIDAD_JUICIO { get; set; }
        public string P9_INTROSPECCION { get; set; }
        public string P10_FIANILIDAD { get; set; }
        public string P11_IMPRESION { get; set; }
        public Nullable<short> P12_DICTAMEN_PSIQUIATRICO { get; set; }
        public Nullable<System.DateTime> ESTUDIO_FEC { get; set; }
        public string COORDINADOR { get; set; }
        public string MEDICO_PSIQUIATRA { get; set; }
    
        public virtual PERSONALIDAD_FUERO_COMUN PERSONALIDAD_FUERO_COMUN { get; set; }
    }
}