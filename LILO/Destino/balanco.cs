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
    
    public partial class balanco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public balanco()
        {
            this.balancoproduto = new HashSet<balancoproduto>();
        }
    
        public int BalancoId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public System.DateTime DATACADASTRO { get; set; }
        public bool ISATIVO { get; set; }
        public int STATUS { get; set; }
        public string NOME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<balancoproduto> balancoproduto { get; set; }
    }
}