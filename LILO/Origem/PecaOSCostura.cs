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
    
    public partial class PecaOSCostura
    {
        public int ID { get; set; }
        public Nullable<int> CodigoOS { get; set; }
        public string Descricao { get; set; }
        public string Obs { get; set; }
        public string Profissional { get; set; }
        public string Local { get; set; }
        public string Prioridade { get; set; }
        public string AgendarProva { get; set; }
        public string RetornoRefazer { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<System.DateTime> DataPrevisao { get; set; }
        public Nullable<System.DateTime> DataEntrega { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string Financeiro { get; set; }
        public Nullable<decimal> ValorRecebido { get; set; }
        public Nullable<decimal> ValorEstimado { get; set; }
        public Nullable<System.DateTime> DataProva { get; set; }
    }
}
