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
    
    public partial class YARDA
    {
        public int ID_YARDA { get; set; }
        public short ID_CENTRO { get; set; }
        public short ID_EDIFICIO { get; set; }
        public short ID_SECTOR { get; set; }
        public Nullable<short> ID_AREA { get; set; }
        public short CELDA_INICIO { get; set; }
        public Nullable<short> CELDA_FINAL { get; set; }
        public Nullable<short> SEMANA_DIA { get; set; }
        public Nullable<short> HORA_INICIO { get; set; }
        public Nullable<short> MINUTO_INICIO { get; set; }
        public Nullable<short> HORA_FIN { get; set; }
        public Nullable<short> MINUTO_FIN { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual AREA AREA { get; set; }
        public virtual SECTOR SECTOR { get; set; }
    }
}
