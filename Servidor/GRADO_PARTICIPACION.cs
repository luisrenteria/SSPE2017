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
    
    public partial class GRADO_PARTICIPACION
    {
        public GRADO_PARTICIPACION()
        {
            this.SENTENCIA = new HashSet<SENTENCIA>();
        }
    
        public short ID_GRADO_PARTICIPACION { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<SENTENCIA> SENTENCIA { get; set; }
    }
}
