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
    
    public partial class ACTIVIDAD_EJE
    {
        public ACTIVIDAD_EJE()
        {
            this.GRUPO = new HashSet<GRUPO>();
        }
    
        public short ID_TIPO_PROGRAMA { get; set; }
        public short ID_ACTIVIDAD { get; set; }
        public short ID_EJE { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ACTIVIDAD ACTIVIDAD { get; set; }
        public virtual EJE EJE { get; set; }
        public virtual ICollection<GRUPO> GRUPO { get; set; }
    }
}