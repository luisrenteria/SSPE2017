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
    
    public partial class REQUISICION_PRODUCTO
    {
        public int ID_REQUISICION { get; set; }
        public int ID_PRODUCTO { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
    
        public virtual REQUISICION REQUISICION { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
