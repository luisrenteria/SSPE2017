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
    
    public partial class CELDA
    {
        public CELDA()
        {
            this.DECOMISO = new HashSet<DECOMISO>();
            this.CAMA = new HashSet<CAMA>();
            this.VISITA_EDIFICIO = new HashSet<VISITA_EDIFICIO>();
            this.VISITA_EDIFICIO1 = new HashSet<VISITA_EDIFICIO>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_EDIFICIO { get; set; }
        public short ID_SECTOR { get; set; }
        public string ID_CELDA { get; set; }
        public string ID_TIPO_SEGURIDAD { get; set; }
        public string ID_TIPO_CELDA { get; set; }
        public Nullable<short> NIVEL_EDIFICIO { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual TIPO_SEGURIDAD TIPO_SEGURIDAD { get; set; }
        public virtual SECTOR SECTOR { get; set; }
        public virtual ICollection<DECOMISO> DECOMISO { get; set; }
        public virtual ICollection<CAMA> CAMA { get; set; }
        public virtual ICollection<VISITA_EDIFICIO> VISITA_EDIFICIO { get; set; }
        public virtual ICollection<VISITA_EDIFICIO> VISITA_EDIFICIO1 { get; set; }
    }
}
