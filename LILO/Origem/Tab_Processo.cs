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
    
    public partial class Tab_Processo
    {
        public int ID { get; set; }
        public string ProdutoFinal { get; set; }
        public Nullable<int> Codigo_produto { get; set; }
        public Nullable<decimal> QtdEstimada { get; set; }
        public Nullable<decimal> QtdReal { get; set; }
        public Nullable<decimal> QtdPerca { get; set; }
        public Nullable<decimal> QtdAtual { get; set; }
        public Nullable<decimal> CustoFinal { get; set; }
        public Nullable<decimal> CustoEstimado { get; set; }
        public Nullable<decimal> CustoRealProduzido { get; set; }
        public Nullable<decimal> CustoIndividual { get; set; }
        public string Status { get; set; }
        public Nullable<int> CodLocalProducao { get; set; }
        public string LocalProducao { get; set; }
        public Nullable<System.DateTime> DataHora { get; set; }
        public Nullable<System.DateTime> DataHoraInicio { get; set; }
        public Nullable<System.DateTime> DataHoraFim { get; set; }
        public Nullable<System.DateTime> TempoDuracao { get; set; }
        public Nullable<System.DateTime> TempoEstimado { get; set; }
        public Nullable<System.DateTime> DiferencaTempo { get; set; }
        public string Observacao { get; set; }
        public Nullable<decimal> QtdEmbarrilada { get; set; }
    }
}