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
    
    public partial class INCIDENCIA_PRODUCTO
    {
        public INCIDENCIA_PRODUCTO()
        {
            this.CALENDARIZAR_ENTREGA_PRODUCTO = new HashSet<CALENDARIZAR_ENTREGA_PRODUCTO>();
        }
    
        public int ID_INCIDENCIA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public string OBSERV { get; set; }
        public string ID_ALMACEN_GRUPO { get; set; }
        public Nullable<short> ID_TIPO_INCIDENCIA { get; set; }
    
        public virtual INCIDENCIA_TIPO INCIDENCIA_TIPO { get; set; }
        public virtual ICollection<CALENDARIZAR_ENTREGA_PRODUCTO> CALENDARIZAR_ENTREGA_PRODUCTO { get; set; }
        public virtual INCIDENCIA INCIDENCIA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
