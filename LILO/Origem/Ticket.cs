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
    
    public partial class Ticket
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string NumeroTicket { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string Data { get; set; }
        public Nullable<System.DateTime> DataBaixa { get; set; }
        public string Status { get; set; }
        public string Selecionado { get; set; }
    }
}
