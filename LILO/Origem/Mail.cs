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
    
    public partial class Mail
    {
        public int ID { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Mensagem { get; set; }
        public string Status { get; set; }
        public string Lida { get; set; }
    }
}
