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
    
    public partial class LancamentosCreditos
    {
        public int ID { get; set; }
        public Nullable<int> IDCartao { get; set; }
        public string NomeCliente { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string Justificativa { get; set; }
        public string FormaPGTO { get; set; }
    }
}
