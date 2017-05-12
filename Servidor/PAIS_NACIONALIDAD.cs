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
    
    public partial class PAIS_NACIONALIDAD
    {
        public PAIS_NACIONALIDAD()
        {
            this.ENTIDAD = new HashSet<ENTIDAD>();
            this.IMPUTADO_PADRES = new HashSet<IMPUTADO_PADRES>();
            this.VISITA_AUTORIZADA = new HashSet<VISITA_AUTORIZADA>();
            this.JUZGADO = new HashSet<JUZGADO>();
            this.CAUSA_PENAL = new HashSet<CAUSA_PENAL>();
            this.PERSONA = new HashSet<PERSONA>();
            this.PERSONA1 = new HashSet<PERSONA>();
            this.INGRESO = new HashSet<INGRESO>();
            this.IMPUTADO = new HashSet<IMPUTADO>();
            this.PROCESO_LIBERTAD = new HashSet<PROCESO_LIBERTAD>();
        }
    
        public short ID_PAIS_NAC { get; set; }
        public string NACIONALIDAD { get; set; }
        public string PAIS { get; set; }
        public Nullable<short> PM { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ICollection<ENTIDAD> ENTIDAD { get; set; }
        public virtual ICollection<IMPUTADO_PADRES> IMPUTADO_PADRES { get; set; }
        public virtual ICollection<VISITA_AUTORIZADA> VISITA_AUTORIZADA { get; set; }
        public virtual ICollection<JUZGADO> JUZGADO { get; set; }
        public virtual ICollection<CAUSA_PENAL> CAUSA_PENAL { get; set; }
        public virtual ICollection<PERSONA> PERSONA { get; set; }
        public virtual ICollection<PERSONA> PERSONA1 { get; set; }
        public virtual ICollection<INGRESO> INGRESO { get; set; }
        public virtual ICollection<IMPUTADO> IMPUTADO { get; set; }
        public virtual ICollection<PROCESO_LIBERTAD> PROCESO_LIBERTAD { get; set; }
    }
}