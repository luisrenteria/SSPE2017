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
    
    public partial class SERVICIO_AUX_DIAG_TRAT
    {
        public SERVICIO_AUX_DIAG_TRAT()
        {
            this.SERVICIO_AUXILIAR_RESULTADO = new HashSet<SERVICIO_AUXILIAR_RESULTADO>();
            this.CANALIZACION_SERV_AUX = new HashSet<CANALIZACION_SERV_AUX>();
            this.SERVICIO_AUX_INTERCONSULTA = new HashSet<SERVICIO_AUX_INTERCONSULTA>();
            this.TV_SERVICIO_AUX_INTERCONSULTA = new HashSet<TV_SERVICIO_AUX_INTERCONSULTA>();
            this.TV_CANALIZACION_SERV_AUX = new HashSet<TV_CANALIZACION_SERV_AUX>();
        }
    
        public int ID_SERV_AUX { get; set; }
        public Nullable<short> ID_SUBTIPO_SADT { get; set; }
        public string DESCR { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual SUBTIPO_SERVICIO_AUX_DIAG_TRAT SUBTIPO_SERVICIO_AUX_DIAG_TRAT { get; set; }
        public virtual ICollection<SERVICIO_AUXILIAR_RESULTADO> SERVICIO_AUXILIAR_RESULTADO { get; set; }
        public virtual ICollection<CANALIZACION_SERV_AUX> CANALIZACION_SERV_AUX { get; set; }
        public virtual ICollection<SERVICIO_AUX_INTERCONSULTA> SERVICIO_AUX_INTERCONSULTA { get; set; }
        public virtual ICollection<TV_SERVICIO_AUX_INTERCONSULTA> TV_SERVICIO_AUX_INTERCONSULTA { get; set; }
        public virtual ICollection<TV_CANALIZACION_SERV_AUX> TV_CANALIZACION_SERV_AUX { get; set; }
    }
}
