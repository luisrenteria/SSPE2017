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
    
    public partial class PARTICULARIDAD
    {
        public PARTICULARIDAD()
        {
            this.MEDIDA_PERSONA = new HashSet<MEDIDA_PERSONA>();
        }
    
        public short ID_PARTICUARIDAD { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<MEDIDA_PERSONA> MEDIDA_PERSONA { get; set; }
    }
}
