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
    
    public partial class crediario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public crediario()
        {
            this.contaspagarreceberparcela = new HashSet<contaspagarreceberparcela>();
        }
    
        public int CrediarioId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public System.DateTime DATACADASTRO { get; set; }
        public int JUROS_TIPO { get; set; }
        public decimal JUROS_TAXA { get; set; }
        public decimal JUROS_MULTA { get; set; }
        public int JUROS_CARENCIA { get; set; }
        public decimal JUROS_ACRESCIMOVALOR { get; set; }
        public decimal JUROS_ACRESCIMOPORCENTAGEM { get; set; }
        public int PESSOAID { get; set; }
        public int PARCELAMENTO_MAXIMO { get; set; }
        public int VENDEDORID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contaspagarreceberparcela> contaspagarreceberparcela { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual pessoa pessoa1 { get; set; }
    }
}
