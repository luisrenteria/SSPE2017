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
    
    public partial class PROCESO_ROL
    {
        public short ID_PROCESO { get; set; }
        public short ID_ROL { get; set; }
        public Nullable<short> INSERTAR { get; set; }
        public Nullable<short> EDITAR { get; set; }
        public Nullable<short> CONSULTAR { get; set; }
        public Nullable<short> IMPRIMIR { get; set; }
        public Nullable<short> DIGITALIZAR { get; set; }
    
        public virtual SISTEMA_ROL SISTEMA_ROL { get; set; }
        public virtual PROCESO PROCESO { get; set; }
    }
}
