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
    
    public partial class Lotes
    {
        public int ID { get; set; }
        public Nullable<int> IDProduto { get; set; }
        public string Lote { get; set; }
        public Nullable<decimal> Quant { get; set; }
        public Nullable<System.DateTime> Validade { get; set; }
        public Nullable<int> CodCor { get; set; }
        public string CodBarras { get; set; }
        public string Descricao { get; set; }
        public string IPR { get; set; }
        public string Campo { get; set; }
        public string Safra { get; set; }
        public string Germinacao { get; set; }
        public string Peneira { get; set; }
        public string Boletim { get; set; }
        public string Termo { get; set; }
        public string Vigor { get; set; }
        public string Area { get; set; }
        public Nullable<System.DateTime> DataPlantio { get; set; }
        public Nullable<System.DateTime> DataBeneficiamento { get; set; }
        public Nullable<System.DateTime> DataColheita { get; set; }
        public Nullable<decimal> QtdAnalisado { get; set; }
        public Nullable<decimal> ScAnalisaco { get; set; }
        public Nullable<decimal> QtdSacas { get; set; }
        public Nullable<decimal> PesoSacas { get; set; }
        public string Categoria { get; set; }
        public Nullable<System.DateTime> DataFabricacao { get; set; }
        public string OutrasEspecies { get; set; }
        public string SementesSilvestres { get; set; }
        public string SementesNocivasToleradas { get; set; }
        public string SementesNocivasProibidas { get; set; }
        public string OutrasDeterminacoesSI { get; set; }
        public Nullable<int> IDBoletim { get; set; }
        public Nullable<int> IDTermo { get; set; }
        public Nullable<System.DateTime> DataTermo { get; set; }
        public Nullable<decimal> SementesMortas { get; set; }
        public Nullable<decimal> SementesDormentes { get; set; }
        public Nullable<decimal> SementesDuras { get; set; }
        public Nullable<decimal> PlantulasAnormais { get; set; }
        public Nullable<decimal> PlantulasNormais { get; set; }
        public string OutrosCultivares { get; set; }
        public string OutrasSementes { get; set; }
        public string MaterialInerte { get; set; }
        public string SementesPuras { get; set; }
        public Nullable<decimal> Representatividade { get; set; }
        public Nullable<double> Comprimento { get; set; }
        public Nullable<double> Largura { get; set; }
        public Nullable<double> MetroTotal { get; set; }
        public Nullable<double> MetroUnidade { get; set; }
        public Nullable<decimal> CustoUN { get; set; }
        public Nullable<decimal> VendaUN { get; set; }
        public Nullable<decimal> CustoTotal { get; set; }
        public Nullable<decimal> VendaTotal { get; set; }
    }
}