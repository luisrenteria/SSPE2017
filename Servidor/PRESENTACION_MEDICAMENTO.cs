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
    
    public partial class PRESENTACION_MEDICAMENTO
    {
        public PRESENTACION_MEDICAMENTO()
        {
            this.PRODUCTO_PRESENTACION_MED = new HashSet<PRODUCTO_PRESENTACION_MED>();
            this.HOJA_ENFERMERIA_SOLUCION = new HashSet<HOJA_ENFERMERIA_SOLUCION>();
            this.RECETA_MEDICA_DETALLE = new HashSet<RECETA_MEDICA_DETALLE>();
            this.HOJA_ENFERMERIA_MEDICAMENTO = new HashSet<HOJA_ENFERMERIA_MEDICAMENTO>();
        }
    
        public short ID_PRESENTACION_MEDICAMENTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual ICollection<PRODUCTO_PRESENTACION_MED> PRODUCTO_PRESENTACION_MED { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_SOLUCION> HOJA_ENFERMERIA_SOLUCION { get; set; }
        public virtual ICollection<RECETA_MEDICA_DETALLE> RECETA_MEDICA_DETALLE { get; set; }
        public virtual ICollection<HOJA_ENFERMERIA_MEDICAMENTO> HOJA_ENFERMERIA_MEDICAMENTO { get; set; }
    }
}
