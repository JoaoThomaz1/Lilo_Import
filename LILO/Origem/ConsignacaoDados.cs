//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LILO.Origem
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConsignacaoDados
    {
        public int ID { get; set; }
        public Nullable<int> IDConsignacao { get; set; }
        public Nullable<int> CodigoProduto { get; set; }
        public string Produto { get; set; }
        public Nullable<decimal> SaldoAnterior { get; set; }
        public Nullable<decimal> Vendas { get; set; }
        public Nullable<decimal> Devolucao { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> ValorUnit { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public string Estoque { get; set; }
        public string Lote { get; set; }
        public Nullable<decimal> AjusteVenda { get; set; }
        public Nullable<decimal> AjustarDevolucao { get; set; }
        public string UN { get; set; }
        public string Cor { get; set; }
        public Nullable<System.DateTime> DataDevolucao { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public string Impresso { get; set; }
        public string Status { get; set; }
        public string CodVenda { get; set; }
    }
}
