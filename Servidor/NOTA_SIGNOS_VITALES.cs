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
    
    public partial class NOTA_SIGNOS_VITALES
    {
        public int ID_ATENCION_MEDICA { get; set; }
        public Nullable<int> ID_RESPONSABLE { get; set; }
        public string TEMPERATURA { get; set; }
        public string FRECUENCIA_CARDIAC { get; set; }
        public string FRECUENCIA_RESPIRA { get; set; }
        public string TENSION_ARTERIAL { get; set; }
        public string PESO { get; set; }
        public string TALLA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string GLUCEMIA { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual PERSONA PERSONA { get; set; }
        public virtual ATENCION_MEDICA ATENCION_MEDICA { get; set; }
    }
}