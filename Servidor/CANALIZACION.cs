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
    
    public partial class CANALIZACION
    {
        public CANALIZACION()
        {
            this.CANALIZACION_ESPECIALIDAD = new HashSet<CANALIZACION_ESPECIALIDAD>();
            this.CANALIZACION_SERV_AUX = new HashSet<CANALIZACION_SERV_AUX>();
            this.INTERCONSULTA_SOLICITUD = new HashSet<INTERCONSULTA_SOLICITUD>();
        }
    
        public int ID_ATENCION_MEDICA { get; set; }
        public Nullable<System.DateTime> ID_FECHA { get; set; }
        public string ID_ESTATUS_CAN { get; set; }
        public string ID_USUARIO { get; set; }
        public short ID_CENTRO_UBI { get; set; }
    
        public virtual CANALIZACION_ESTATUS CANALIZACION_ESTATUS { get; set; }
        public virtual NOTA_MEDICA NOTA_MEDICA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CANALIZACION_ESPECIALIDAD> CANALIZACION_ESPECIALIDAD { get; set; }
        public virtual ICollection<CANALIZACION_SERV_AUX> CANALIZACION_SERV_AUX { get; set; }
        public virtual ICollection<INTERCONSULTA_SOLICITUD> INTERCONSULTA_SOLICITUD { get; set; }
    }
}
