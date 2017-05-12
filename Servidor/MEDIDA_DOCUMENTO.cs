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
    
    public partial class MEDIDA_DOCUMENTO
    {
        public MEDIDA_DOCUMENTO()
        {
            this.MEDIDA_LIBERTAD = new HashSet<MEDIDA_LIBERTAD>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_PROCESO_LIBERTAD { get; set; }
        public short ID_DOCUMENTO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public byte[] DOCUMENTO { get; set; }
        public string VISTO { get; set; }
        public string OFICIO { get; set; }
        public Nullable<int> ID_EMPLEADO { get; set; }
        public string TITULO { get; set; }
        public string SENTIDO { get; set; }
        public Nullable<decimal> ID_FUENTE { get; set; }
        public Nullable<decimal> ID_TIPDOCMED { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual FUENTE FUENTE { get; set; }
        public virtual TIPO_DOCUMENTO_MEDIDA TIPO_DOCUMENTO_MEDIDA { get; set; }
        public virtual ICollection<MEDIDA_LIBERTAD> MEDIDA_LIBERTAD { get; set; }
        public virtual PROCESO_LIBERTAD PROCESO_LIBERTAD { get; set; }
    }
}