//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_BiometricoService.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class GRUPO_BM
    {
        public GRUPO_BM()
        {
            this.GRUPO_HORARIO = new HashSet<GRUPO_HORARIO_BM>();
            this.GRUPO_PARTICIPANTE = new HashSet<GRUPO_PARTICIPANTE_BM>();
        }
    
        public short ID_CENTRO { get; set; }
        public short ID_TIPO_PROGRAMA { get; set; }
        public short ID_ACTIVIDAD { get; set; }
        public short ID_GRUPO { get; set; }
        public short ID_DEPARTAMENTO { get; set; }
        public Nullable<int> ID_GRUPO_RESPONSABLE { get; set; }
        public Nullable<short> ID_ESTATUS_GRUPO { get; set; }
        public string RECURRENCIA { get; set; }
        public Nullable<System.DateTime> FEC_INICIO { get; set; }
        public Nullable<System.DateTime> FEC_FIN { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<GRUPO_HORARIO_BM> GRUPO_HORARIO { get; set; }
        public virtual ICollection<GRUPO_PARTICIPANTE_BM> GRUPO_PARTICIPANTE { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}
