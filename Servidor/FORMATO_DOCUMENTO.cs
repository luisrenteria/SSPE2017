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
    
    public partial class FORMATO_DOCUMENTO
    {
        public FORMATO_DOCUMENTO()
        {
            this.IMPUTADO_TIPO_DOCUMENTO = new HashSet<IMPUTADO_TIPO_DOCUMENTO>();
            this.INTER_DOCTO = new HashSet<INTER_DOCTO>();
            this.HISTORIA_CLINICA_DOCUMENTO = new HashSet<HISTORIA_CLINICA_DOCUMENTO>();
            this.SERVICIO_AUXILIAR_RESULTADO = new HashSet<SERVICIO_AUXILIAR_RESULTADO>();
            this.EXCARCELACION_DESTINO = new HashSet<EXCARCELACION_DESTINO>();
            this.HISTORICO_DOCUMENTOS = new HashSet<HISTORICO_DOCUMENTOS>();
        }
    
        public short ID_FORMATO { get; set; }
        public string DESCR { get; set; }
    
        public virtual ICollection<IMPUTADO_TIPO_DOCUMENTO> IMPUTADO_TIPO_DOCUMENTO { get; set; }
        public virtual ICollection<INTER_DOCTO> INTER_DOCTO { get; set; }
        public virtual ICollection<HISTORIA_CLINICA_DOCUMENTO> HISTORIA_CLINICA_DOCUMENTO { get; set; }
        public virtual ICollection<SERVICIO_AUXILIAR_RESULTADO> SERVICIO_AUXILIAR_RESULTADO { get; set; }
        public virtual ICollection<EXCARCELACION_DESTINO> EXCARCELACION_DESTINO { get; set; }
        public virtual ICollection<HISTORICO_DOCUMENTOS> HISTORICO_DOCUMENTOS { get; set; }
    }
}