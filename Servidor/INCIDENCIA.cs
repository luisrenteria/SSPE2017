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
    
    public partial class INCIDENCIA
    {
        public INCIDENCIA()
        {
            this.INCIDENCIA_PRODUCTO = new HashSet<INCIDENCIA_PRODUCTO>();
        }
    
        public int ID_INCIDENCIA { get; set; }
        public Nullable<short> ID_ALMACEN { get; set; }
        public Nullable<int> ID_ORDEN_COMPRA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string ID_USUARIO { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ALMACEN ALMACEN { get; set; }
        public virtual ICollection<INCIDENCIA_PRODUCTO> INCIDENCIA_PRODUCTO { get; set; }
        public virtual ORDEN_COMPRA ORDEN_COMPRA { get; set; }
    }
}
