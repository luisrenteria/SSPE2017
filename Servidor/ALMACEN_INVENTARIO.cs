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
    
    public partial class ALMACEN_INVENTARIO
    {
        public short ID_ALMACEN { get; set; }
        public int ID_LOTE { get; set; }
        public int ID_PRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<System.DateTime> CADUCIDAD_FEC { get; set; }
    
        public virtual ALMACEN ALMACEN { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
