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
    
    public partial class PROVEEDOR
    {
        public PROVEEDOR()
        {
            this.ORDEN_COMPRA = new HashSet<ORDEN_COMPRA>();
        }
    
        public int ID_PROV { get; set; }
        public string NOMBRE { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<short> ESTADO { get; set; }
        public Nullable<short> MUNICIPIO { get; set; }
        public Nullable<long> TELEFONO { get; set; }
        public Nullable<long> TELEFONO2 { get; set; }
        public Nullable<long> FAX { get; set; }
        public string CONTACTO { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> FECHA_ALTA { get; set; }
        public string ACTIVO { get; set; }
        public Nullable<decimal> FLAG_MORAL { get; set; }
        public string RFC { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string CTELEFONO { get; set; }
        public string CTELEFONO2 { get; set; }
        public string CFAX { get; set; }
        public string ID_PROD_GRUPO { get; set; }
    
        public virtual ALMACEN_GRUPO ALMACEN_GRUPO { get; set; }
        public virtual ICollection<ORDEN_COMPRA> ORDEN_COMPRA { get; set; }
    }
}
