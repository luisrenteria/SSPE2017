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
    
    public partial class RECETA_MEDICA_DETALLE
    {
        public RECETA_MEDICA_DETALLE()
        {
            this.HOJA_ENFERMERIA_MEDICAMENTO = new HashSet<HOJA_ENFERMERIA_MEDICAMENTO>();
        }
    
        public int ID_FOLIO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public Nullable<decimal> DOSIS { get; set; }
        public Nullable<short> DURACION { get; set; }
        public Nullable<short> DESAYUNO { get; set; }
        public Nullable<short> COMIDA { get; set; }
        public Nullable<short> CENA { get; set; }
        public string OBSERV { get; set; }
        public short ID_CENTRO_UBI { get; set; }
        public int ID_ATENCION_MEDICA { get; set; }
        public Nullable<short> ID_PRESENTACION_MEDICAMENTO { get; set; }
        public Nullable<int> CANCELA_ID_ATENCION_MEDICA { get; set; }
        public Nullable<short> CANCELA_ID_CENTRO_UBI { get; set; }
    
        public virtual NOTA_MEDICA NOTA_MEDICA { get; set; }
        public virtual PRESENTACION_MEDICAMENTO PRESENTACION_MEDICAMENTO { get; set; }
        public virtual RECETA_MEDICA RECETA_MEDICA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_MEDICAMENTO> HOJA_ENFERMERIA_MEDICAMENTO { get; set; }
    }
}
