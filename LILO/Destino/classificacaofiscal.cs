//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LILO.Destino
{
    using System;
    using System.Collections.Generic;
    
    public partial class classificacaofiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public classificacaofiscal()
        {
            this.fecpexcecoes = new HashSet<fecpexcecoes>();
            this.produto = new HashSet<produto>();
        }
    
        public int ClassificacaoFiscalId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public System.DateTime DATACADASTRO { get; set; }
        public bool ISATIVO { get; set; }
        public decimal ALIQUOTA { get; set; }
        public string DESCRICAO { get; set; }
        public string NCM { get; set; }
        public string CODIGO_ANP { get; set; }
        public decimal ALIQUOTA_FECP { get; set; }
        public string PIS_CST { get; set; }
        public string COFINS_CST { get; set; }
        public decimal ALIQUOTA_ICMS { get; set; }
        public string CSOSNCST { get; set; }
        public string CEST { get; set; }
        public string CFOP_NF { get; set; }
        public string CFOP_NFC { get; set; }
        public Nullable<System.DateTime> VIGENCIA_NCM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fecpexcecoes> fecpexcecoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produto { get; set; }
    }
}
