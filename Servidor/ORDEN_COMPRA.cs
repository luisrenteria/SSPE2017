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
    
    public partial class ORDEN_COMPRA
    {
        public ORDEN_COMPRA()
        {
            this.ORDEN_COMPRA_DETALLE = new HashSet<ORDEN_COMPRA_DETALLE>();
            this.CALENDARIZAR_ENTREGA = new HashSet<CALENDARIZAR_ENTREGA>();
            this.MOVIMIENTO = new HashSet<MOVIMIENTO>();
            this.INCIDENCIA = new HashSet<INCIDENCIA>();
        }
    
        public int ID_ORDEN_COMPRA { get; set; }
        public Nullable<int> NUM_ORDEN { get; set; }
        public Nullable<int> ID_REQUISICION { get; set; }
        public Nullable<int> ID_PROV { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string ID_USUARIO { get; set; }
        public Nullable<System.DateTime> MES { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ORDEN_COMPRA_ESTATUS ORDEN_COMPRA_ESTATUS { get; set; }
        public virtual ICollection<ORDEN_COMPRA_DETALLE> ORDEN_COMPRA_DETALLE { get; set; }
        public virtual REQUISICION REQUISICION { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual ICollection<CALENDARIZAR_ENTREGA> CALENDARIZAR_ENTREGA { get; set; }
        public virtual ICollection<MOVIMIENTO> MOVIMIENTO { get; set; }
        public virtual ICollection<INCIDENCIA> INCIDENCIA { get; set; }
    }
}
