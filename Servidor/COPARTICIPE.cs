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
    
    public partial class COPARTICIPE
    {
        public COPARTICIPE()
        {
            this.COPARTICIPE_ALIAS = new HashSet<COPARTICIPE_ALIAS>();
            this.COPARTICIPE_APODO = new HashSet<COPARTICIPE_APODO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_ANIO { get; set; }
        public int ID_IMPUTADO { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_CAUSA_PENAL { get; set; }
        public short ID_COPARTICIPE { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<COPARTICIPE_ALIAS> COPARTICIPE_ALIAS { get; set; }
        public virtual ICollection<COPARTICIPE_APODO> COPARTICIPE_APODO { get; set; }
        public virtual CAUSA_PENAL CAUSA_PENAL { get; set; }
    }
}
