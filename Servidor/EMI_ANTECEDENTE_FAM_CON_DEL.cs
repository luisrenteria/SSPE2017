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
    
    public partial class EMI_ANTECEDENTE_FAM_CON_DEL
    {
        public int ID_EMI { get; set; }
        public short ID_EMI_CONS { get; set; }
        public short ID_EMI_ANTECEDENTE { get; set; }
        public Nullable<short> ID_PARENTESCO { get; set; }
        public Nullable<short> ANIO { get; set; }
        public Nullable<short> ID_DELITO { get; set; }
        public Nullable<short> ID_RELACION { get; set; }
        public Nullable<int> ID_EMISOR { get; set; }
        public string DELITO { get; set; }
    
        public virtual EMI EMI { get; set; }
        public virtual EMISOR EMISOR { get; set; }
        public virtual INGRESO_DELITO INGRESO_DELITO { get; set; }
        public virtual TIPO_REFERENCIA TIPO_REFERENCIA { get; set; }
        public virtual TIPO_RELACION TIPO_RELACION { get; set; }
    }
}