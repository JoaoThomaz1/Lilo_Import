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
    
    public partial class regracomissaoproduto
    {
        public int RegraComissaoProdutoId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public System.DateTime DATACADASTRO { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public int RegraComissaoId { get; set; }
        public int PRODUTOID { get; set; }
    
        public virtual regracomissao regracomissao { get; set; }
    }
}
