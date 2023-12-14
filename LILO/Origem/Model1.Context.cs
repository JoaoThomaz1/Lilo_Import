﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LiloEntities1 : DbContext
    {
        public LiloEntities1()
            : base("name=LiloEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AberturaCaixa> AberturaCaixa { get; set; }
        public virtual DbSet<AgrupamentoProd> AgrupamentoProd { get; set; }
        public virtual DbSet<Ambientes> Ambientes { get; set; }
        public virtual DbSet<Arquivos> Arquivos { get; set; }
        public virtual DbSet<ArquivosDados> ArquivosDados { get; set; }
        public virtual DbSet<AutoSenha> AutoSenha { get; set; }
        public virtual DbSet<AutoSenha2> AutoSenha2 { get; set; }
        public virtual DbSet<BanhoTosa> BanhoTosa { get; set; }
        public virtual DbSet<BanhoTosaDados> BanhoTosaDados { get; set; }
        public virtual DbSet<BDResultado> BDResultado { get; set; }
        public virtual DbSet<Brindes> Brindes { get; set; }
        public virtual DbSet<Cad_Convenios> Cad_Convenios { get; set; }
        public virtual DbSet<Cad_Func> Cad_Func { get; set; }
        public virtual DbSet<Cad_OS> Cad_OS { get; set; }
        public virtual DbSet<Cad_OS_Inform> Cad_OS_Inform { get; set; }
        public virtual DbSet<Cad_OS_Online> Cad_OS_Online { get; set; }
        public virtual DbSet<Cad_OS_Online_Modulos> Cad_OS_Online_Modulos { get; set; }
        public virtual DbSet<Cad_prod_anterior> Cad_prod_anterior { get; set; }
        public virtual DbSet<Cad_usu> Cad_usu { get; set; }
        public virtual DbSet<Cad_Veiculos> Cad_Veiculos { get; set; }
        public virtual DbSet<CadAnimais> CadAnimais { get; set; }
        public virtual DbSet<CadAtacado> CadAtacado { get; set; }
        public virtual DbSet<CadAtacadoDados> CadAtacadoDados { get; set; }
        public virtual DbSet<CadServicoOS_Inform> CadServicoOS_Inform { get; set; }
        public virtual DbSet<CadVet> CadVet { get; set; }
        public virtual DbSet<Caixa> Caixa { get; set; }
        public virtual DbSet<Campo> Campo { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cartao> Cartao { get; set; }
        public virtual DbSet<CartoesPDV> CartoesPDV { get; set; }
        public virtual DbSet<CartoesVenda> CartoesVenda { get; set; }
        public virtual DbSet<Cidades> Cidades { get; set; }
        public virtual DbSet<Cli_Fornec> Cli_Fornec { get; set; }
        public virtual DbSet<Cli_Fornec2> Cli_Fornec2 { get; set; }
        public virtual DbSet<Coletor> Coletor { get; set; }
        public virtual DbSet<ColetorDados> ColetorDados { get; set; }
        public virtual DbSet<Comandos> Comandos { get; set; }
        public virtual DbSet<Comissao> Comissao { get; set; }
        public virtual DbSet<ComissaoVendedor> ComissaoVendedor { get; set; }
        public virtual DbSet<Comissoes> Comissoes { get; set; }
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<Consignacao> Consignacao { get; set; }
        public virtual DbSet<ConsignacaoDados> ConsignacaoDados { get; set; }
        public virtual DbSet<ContaGrafica> ContaGrafica { get; set; }
        public virtual DbSet<ContasPagar> ContasPagar { get; set; }
        public virtual DbSet<ContasReceber> ContasReceber { get; set; }
        public virtual DbSet<ContasReceberNFE> ContasReceberNFE { get; set; }
        public virtual DbSet<Contatos> Contatos { get; set; }
        public virtual DbSet<ControleCaixa> ControleCaixa { get; set; }
        public virtual DbSet<ControleCodigos> ControleCodigos { get; set; }
        public virtual DbSet<ControleFerramentas> ControleFerramentas { get; set; }
        public virtual DbSet<Cores> Cores { get; set; }
        public virtual DbSet<CurvaHora> CurvaHora { get; set; }
        public virtual DbSet<CurvaPeriodo> CurvaPeriodo { get; set; }
        public virtual DbSet<CustosFixos> CustosFixos { get; set; }
        public virtual DbSet<DadosBoletim> DadosBoletim { get; set; }
        public virtual DbSet<DadosCotacao> DadosCotacao { get; set; }
        public virtual DbSet<DadosNFE> DadosNFE { get; set; }
        public virtual DbSet<DadosRepresentantes> DadosRepresentantes { get; set; }
        public virtual DbSet<DadosSoLicitacao> DadosSoLicitacao { get; set; }
        public virtual DbSet<DadosTransferencia> DadosTransferencia { get; set; }
        public virtual DbSet<Datas> Datas { get; set; }
        public virtual DbSet<Degustacoes> Degustacoes { get; set; }
        public virtual DbSet<DescontoServicos> DescontoServicos { get; set; }
        public virtual DbSet<Desempenho> Desempenho { get; set; }
        public virtual DbSet<EquipEmpresa> EquipEmpresa { get; set; }
        public virtual DbSet<EstoqueNFE> EstoqueNFE { get; set; }
        public virtual DbSet<EtiquetaNF> EtiquetaNF { get; set; }
        public virtual DbSet<Fabricante> Fabricante { get; set; }
        public virtual DbSet<FaturFran> FaturFran { get; set; }
        public virtual DbSet<FechaHVet> FechaHVet { get; set; }
        public virtual DbSet<FechamentoCaixa> FechamentoCaixa { get; set; }
        public virtual DbSet<Ferramentas> Ferramentas { get; set; }
        public virtual DbSet<FiltroMes> FiltroMes { get; set; }
        public virtual DbSet<FiltroMesDados> FiltroMesDados { get; set; }
        public virtual DbSet<FluxoCaixa> FluxoCaixa { get; set; }
        public virtual DbSet<Fluxograma> Fluxograma { get; set; }
        public virtual DbSet<FluxoSemana> FluxoSemana { get; set; }
        public virtual DbSet<Folha> Folha { get; set; }
        public virtual DbSet<FormaPgto> FormaPgto { get; set; }
        public virtual DbSet<GrupoContatos> GrupoContatos { get; set; }
        public virtual DbSet<GrupoPlanoContas> GrupoPlanoContas { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<GrupoServicos> GrupoServicos { get; set; }
        public virtual DbSet<GrupoTransportadoras> GrupoTransportadoras { get; set; }
        public virtual DbSet<HistoricoSistema> HistoricoSistema { get; set; }
        public virtual DbSet<Impresso> Impresso { get; set; }
        public virtual DbSet<InformComplementares> InformComplementares { get; set; }
        public virtual DbSet<LancamentosCreditos> LancamentosCreditos { get; set; }
        public virtual DbSet<LancBancario> LancBancario { get; set; }
        public virtual DbSet<LancCaixa> LancCaixa { get; set; }
        public virtual DbSet<LinhaEmissaoNFE> LinhaEmissaoNFE { get; set; }
        public virtual DbSet<ListaNegra> ListaNegra { get; set; }
        public virtual DbSet<Local_PCP> Local_PCP { get; set; }
        public virtual DbSet<Local_Producao> Local_Producao { get; set; }
        public virtual DbSet<Lotes> Lotes { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<NFSE> NFSE { get; set; }
        public virtual DbSet<NFSEDados> NFSEDados { get; set; }
        public virtual DbSet<NotaProdutor> NotaProdutor { get; set; }
        public virtual DbSet<NotasNSU> NotasNSU { get; set; }
        public virtual DbSet<NumPerdidos> NumPerdidos { get; set; }
        public virtual DbSet<NumRemessa> NumRemessa { get; set; }
        public virtual DbSet<OrcamentosDados> OrcamentosDados { get; set; }
        public virtual DbSet<OrcMontado> OrcMontado { get; set; }
        public virtual DbSet<OrcMontadoAmbientes> OrcMontadoAmbientes { get; set; }
        public virtual DbSet<OrcMontadoDados> OrcMontadoDados { get; set; }
        public virtual DbSet<OrcMontadoGrupos> OrcMontadoGrupos { get; set; }
        public virtual DbSet<Pagamentos> Pagamentos { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<PecaOSCostura> PecaOSCostura { get; set; }
        public virtual DbSet<Permutas> Permutas { get; set; }
        public virtual DbSet<PlanoContas> PlanoContas { get; set; }
        public virtual DbSet<PlanoContasCredito> PlanoContasCredito { get; set; }
        public virtual DbSet<PlanoContasDebito> PlanoContasDebito { get; set; }
        public virtual DbSet<Pneus> Pneus { get; set; }
        public virtual DbSet<Postos> Postos { get; set; }
        public virtual DbSet<PrazoMedio> PrazoMedio { get; set; }
        public virtual DbSet<PrecoVenda> PrecoVenda { get; set; }
        public virtual DbSet<ProdutosVendidosFran> ProdutosVendidosFran { get; set; }
        public virtual DbSet<Profissoes> Profissoes { get; set; }
        public virtual DbSet<RaizPlanoContas> RaizPlanoContas { get; set; }
        public virtual DbSet<RankingCli> RankingCli { get; set; }
        public virtual DbSet<RankingProd> RankingProd { get; set; }
        public virtual DbSet<RankingProd2> RankingProd2 { get; set; }
        public virtual DbSet<Rastreamento> Rastreamento { get; set; }
        public virtual DbSet<ReferenciasComerciais> ReferenciasComerciais { get; set; }
        public virtual DbSet<RelacaoCompraVenda> RelacaoCompraVenda { get; set; }
        public virtual DbSet<RelatMapa> RelatMapa { get; set; }
        public virtual DbSet<Representantes> Representantes { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<ResultMapaProd> ResultMapaProd { get; set; }
        public virtual DbSet<Romaneio> Romaneio { get; set; }
        public virtual DbSet<Servicos> Servicos { get; set; }
        public virtual DbSet<StatusOS> StatusOS { get; set; }
        public virtual DbSet<SubGrupo> SubGrupo { get; set; }
        public virtual DbSet<Tab_Processo> Tab_Processo { get; set; }
        public virtual DbSet<Tab_ProcessoDados> Tab_ProcessoDados { get; set; }
        public virtual DbSet<Tab_ProcessoDadosProdutos> Tab_ProcessoDadosProdutos { get; set; }
        public virtual DbSet<TabAnimais> TabAnimais { get; set; }
        public virtual DbSet<tabBalanco> tabBalanco { get; set; }
        public virtual DbSet<TabBoletim> TabBoletim { get; set; }
        public virtual DbSet<TabBoletimCampo> TabBoletimCampo { get; set; }
        public virtual DbSet<TabColecao> TabColecao { get; set; }
        public virtual DbSet<TabCompras> TabCompras { get; set; }
        public virtual DbSet<TabCotacao> TabCotacao { get; set; }
        public virtual DbSet<TabelaPreco> TabelaPreco { get; set; }
        public virtual DbSet<TabelaPrecoProdutos> TabelaPrecoProdutos { get; set; }
        public virtual DbSet<TabelasPreco> TabelasPreco { get; set; }
        public virtual DbSet<TabEmbarrilar> TabEmbarrilar { get; set; }
        public virtual DbSet<TabFormas> TabFormas { get; set; }
        public virtual DbSet<tabIntegracao> tabIntegracao { get; set; }
        public virtual DbSet<TabInutilizar> TabInutilizar { get; set; }
        public virtual DbSet<TabMDFEMunic> TabMDFEMunic { get; set; }
        public virtual DbSet<TabMDFESeguro> TabMDFESeguro { get; set; }
        public virtual DbSet<TabMinimo> TabMinimo { get; set; }
        public virtual DbSet<TabModelagem> TabModelagem { get; set; }
        public virtual DbSet<TabModelagemRelat> TabModelagemRelat { get; set; }
        public virtual DbSet<TabNFRef> TabNFRef { get; set; }
        public virtual DbSet<TabNossoNumero> TabNossoNumero { get; set; }
        public virtual DbSet<TabPacotePet> TabPacotePet { get; set; }
        public virtual DbSet<TabPacotePetDados> TabPacotePetDados { get; set; }
        public virtual DbSet<TabPagamentos> TabPagamentos { get; set; }
        public virtual DbSet<TabPagamentos2> TabPagamentos2 { get; set; }
        public virtual DbSet<TabPrisma> TabPrisma { get; set; }
        public virtual DbSet<TabRecibo> TabRecibo { get; set; }
        public virtual DbSet<TabRegras> TabRegras { get; set; }
        public virtual DbSet<TabSolicitacao> TabSolicitacao { get; set; }
        public virtual DbSet<TabStatus> TabStatus { get; set; }
        public virtual DbSet<TabTecidos> TabTecidos { get; set; }
        public virtual DbSet<TabTermos> TabTermos { get; set; }
        public virtual DbSet<TabVacinas> TabVacinas { get; set; }
        public virtual DbSet<Tecnicos> Tecnicos { get; set; }
        public virtual DbSet<Temp> Temp { get; set; }
        public virtual DbSet<TempAdicional> TempAdicional { get; set; }
        public virtual DbSet<TempCompraFornec> TempCompraFornec { get; set; }
        public virtual DbSet<TempComprasIdeal> TempComprasIdeal { get; set; }
        public virtual DbSet<TempComprasProdutos> TempComprasProdutos { get; set; }
        public virtual DbSet<TempContas> TempContas { get; set; }
        public virtual DbSet<TempFechamento> TempFechamento { get; set; }
        public virtual DbSet<TempFinanceiro> TempFinanceiro { get; set; }
        public virtual DbSet<TempLancBancario> TempLancBancario { get; set; }
        public virtual DbSet<TempNFE> TempNFE { get; set; }
        public virtual DbSet<TempNFE2> TempNFE2 { get; set; }
        public virtual DbSet<Temporario> Temporario { get; set; }
        public virtual DbSet<TempPlanoContas> TempPlanoContas { get; set; }
        public virtual DbSet<TempProd> TempProd { get; set; }
        public virtual DbSet<TempVacina> TempVacina { get; set; }
        public virtual DbSet<TempVendadados> TempVendadados { get; set; }
        public virtual DbSet<TermoBoletim> TermoBoletim { get; set; }
        public virtual DbSet<TermoBoletimDados> TermoBoletimDados { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Transferencias> Transferencias { get; set; }
        public virtual DbSet<Transportadora> Transportadora { get; set; }
        public virtual DbSet<TributoAtacado> TributoAtacado { get; set; }
        public virtual DbSet<Trocas> Trocas { get; set; }
        public virtual DbSet<UnProd> UnProd { get; set; }
        public virtual DbSet<ValeFunc> ValeFunc { get; set; }
        public virtual DbSet<ValesFunc> ValesFunc { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }
        public virtual DbSet<VendaDados> VendaDados { get; set; }
        public virtual DbSet<VendaDados_Cliente> VendaDados_Cliente { get; set; }
        public virtual DbSet<VendaDadosNFE> VendaDadosNFE { get; set; }
        public virtual DbSet<VendaNFE> VendaNFE { get; set; }
        public virtual DbSet<VendaPeriodo> VendaPeriodo { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Bairro> Bairro { get; set; }
        public virtual DbSet<Cad_prod> Cad_prod { get; set; }
        public virtual DbSet<Cad_prod2> Cad_prod2 { get; set; }
        public virtual DbSet<CFOP_CODIGO> CFOP_CODIGO { get; set; }
        public virtual DbSet<CFOP_GRUPO> CFOP_GRUPO { get; set; }
        public virtual DbSet<CFOP_OPERACAO> CFOP_OPERACAO { get; set; }
        public virtual DbSet<CurvaMes> CurvaMes { get; set; }
        public virtual DbSet<cxSchedulerResourcesTable> cxSchedulerResourcesTable { get; set; }
        public virtual DbSet<cxSchedulerTable> cxSchedulerTable { get; set; }
        public virtual DbSet<DadosNotasNSU> DadosNotasNSU { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresasClientes> EmpresasClientes { get; set; }
        public virtual DbSet<Entregador> Entregador { get; set; }
        public virtual DbSet<Equipamentos> Equipamentos { get; set; }
        public virtual DbSet<MDFEletr> MDFEletr { get; set; }
        public virtual DbSet<Multas> Multas { get; set; }
        public virtual DbSet<NCM> NCM { get; set; }
        public virtual DbSet<NFCEletr> NFCEletr { get; set; }
        public virtual DbSet<NFEletr> NFEletr { get; set; }
        public virtual DbSet<NFEntrada> NFEntrada { get; set; }
        public virtual DbSet<NFSEletr> NFSEletr { get; set; }
        public virtual DbSet<Orcamentos> Orcamentos { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<PrismaDados> PrismaDados { get; set; }
        public virtual DbSet<RegistroTransp> RegistroTransp { get; set; }
        public virtual DbSet<SITUACAO_TRIBUTARIA> SITUACAO_TRIBUTARIA { get; set; }
        public virtual DbSet<TabOSRH> TabOSRH { get; set; }
        public virtual DbSet<TABOSRHCandidatos> TABOSRHCandidatos { get; set; }
    }
}
