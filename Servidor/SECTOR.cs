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
    
    public partial class SECTOR
    {
        public SECTOR()
        {
            this.CELDA = new HashSet<CELDA>();
            this.SECTOR_OBSERVACION = new HashSet<SECTOR_OBSERVACION>();
            this.VISITA_EDIFICIO = new HashSet<VISITA_EDIFICIO>();
            this.YARDA = new HashSet<YARDA>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_EDIFICIO { get; set; }
        public short ID_SECTOR { get; set; }
        public string DESCR { get; set; }
        public byte[] PLANO { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<CELDA> CELDA { get; set; }
        public virtual ICollection<SECTOR_OBSERVACION> SECTOR_OBSERVACION { get; set; }
        public virtual EDIFICIO EDIFICIO { get; set; }
        public virtual ICollection<VISITA_EDIFICIO> VISITA_EDIFICIO { get; set; }
        public virtual ICollection<YARDA> YARDA { get; set; }
    }
}
