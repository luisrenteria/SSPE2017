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
    
    public partial class REQUISICION_CENTRO
    {
        public REQUISICION_CENTRO()
        {
            this.REQUISICION_CENTRO_PRODUCTO = new HashSet<REQUISICION_CENTRO_PRODUCTO>();
            this.TRASPASO = new HashSet<TRASPASO>();
        }
    
        public int ID_REQUISICION { get; set; }
        public Nullable<short> ID_ALMACEN { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<short> ANIO { get; set; }
        public Nullable<short> MES { get; set; }
        public string OBSERV { get; set; }
        public string ESTATUS { get; set; }
        public string ID_USUARIO { get; set; }
        public string PERIODO { get; set; }
        public Nullable<int> ID_REQ_CONCENTRA { get; set; }
        public Nullable<short> ID_TIPO { get; set; }
    
        public virtual ALMACEN ALMACEN { get; set; }
        public virtual REQ_CENTRO_ESTATUS REQ_CENTRO_ESTATUS { get; set; }
        public virtual REQUISICION REQUISICION { get; set; }
        public virtual ICollection<REQUISICION_CENTRO_PRODUCTO> REQUISICION_CENTRO_PRODUCTO { get; set; }
        public virtual REQUISICION_TIPO REQUISICION_TIPO { get; set; }
        public virtual ICollection<TRASPASO> TRASPASO { get; set; }
    }
}
