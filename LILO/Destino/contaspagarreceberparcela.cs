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
    
    public partial class contaspagarreceberparcela
    {
        public int ContasPagarReceberParcelaId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public System.DateTime DATACADASTRO { get; set; }
        public int Cheque_BancoID { get; set; }
        public string Cheque_Agencia { get; set; }
        public string Cheque_Conta { get; set; }
        public string Cheque_Numero { get; set; }
        public string Cheque_Emitente { get; set; }
        public Nullable<System.DateTime> DATALIQUIDACAO { get; set; }
        public Nullable<System.DateTime> DATABAIXA { get; set; }
        public string DOCUMENTO { get; set; }
        public bool ISLIQUIDADO { get; set; }
        public string OBSERVACOES { get; set; }
        public Nullable<int> PEDIDOID { get; set; }
        public Nullable<int> PESSOAID { get; set; }
        public int STATUS { get; set; }
        public int TIPOCONTA { get; set; }
        public int TIPOPAGAMENTORECEBIMENTO { get; set; }
        public decimal VALOR { get; set; }
        public decimal VALOR_ACRESCIMO { get; set; }
        public decimal VALOR_DESCONTO { get; set; }
        public decimal VALOR_JUROS { get; set; }
        public decimal VALOR_MULTA { get; set; }
        public decimal VALOR_PAGO { get; set; }
        public System.DateTime VENCIMENTO { get; set; }
        public decimal VALOR_TROCO { get; set; }
        public Nullable<int> CREDIARIOID { get; set; }
        public bool ISAGRUPADA { get; set; }
        public Nullable<int> PARCELADESTINO { get; set; }
        public bool ISATIVO { get; set; }
        public Nullable<int> TIPOORIGEMPARCELA { get; set; }
    
        public virtual crediario crediario { get; set; }
        public virtual pedido pedido { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}