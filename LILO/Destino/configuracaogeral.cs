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
    
    public partial class configuracaogeral
    {
        public int ConfiguracaoGeralId { get; set; }
        public System.DateTime ALTERACAODATA { get; set; }
        public string ALTERACAOUSUARIO { get; set; }
        public string DADOSCADASTRAIS_BAIRRO { get; set; }
        public string DADOSCADASTRAIS_CELULAR { get; set; }
        public string DADOSCADASTRAIS_CELULAR_OPERADORA { get; set; }
        public string DADOSCADASTRAIS_CEP { get; set; }
        public string DADOSCADASTRAIS_CNAE { get; set; }
        public string DADOSCADASTRAIS_CPFCNPJ { get; set; }
        public string DADOSCADASTRAIS_COMPLEMENTO { get; set; }
        public string DADOSCADASTRAIS_CONTATO { get; set; }
        public int DADOSCADASTRAIS_CRT { get; set; }
        public string DADOSCADASTRAIS_EMAIL { get; set; }
        public string DADOSCADASTRAIS_EMAIL_FINANCEIRO { get; set; }
        public string DADOSCADASTRAIS_FAX { get; set; }
        public string DADOSCADASTRAIS_IE { get; set; }
        public string DADOSCADASTRAIS_INSCRICAOMUNICIPAL { get; set; }
        public byte[] DADOSCADASTRAIS_LOGOMARCA { get; set; }
        public string DADOSCADASTRAIS_LOGRADOURO { get; set; }
        public string DADOSCADASTRAIS_MUNICIPIO { get; set; }
        public string DADOSCADASTRAIS_NOMEFANTASIA { get; set; }
        public string DADOSCADASTRAIS_NOMERAZAOSOCIAL { get; set; }
        public string DADOSCADASTRAIS_NUMERO { get; set; }
        public int DADOSCADASTRAIS_PAIS_ID { get; set; }
        public string DADOSCADASTRAIS_RESPONSAVEL { get; set; }
        public string DADOSCADASTRAIS_TELEFONE { get; set; }
        public string DADOSCADASTRAIS_UF { get; set; }
        public string CERTIFICADO_DIGITAL { get; set; }
        public int FORMATODECIMAL_QUANTIDADE { get; set; }
        public int FORMATODECIMAL_MONETARIO { get; set; }
        public int FORMATODECIMAL_PORCENTAGEM { get; set; }
        public bool PESQUISAPADRAO_REFERENCIA { get; set; }
        public int TIPORECEBIMENTO_PADRAO { get; set; }
        public int TIPOPAGAMENTO_PADRAO { get; set; }
        public int NFCE_ULTIMONUMERO { get; set; }
        public int NFCE_AMBIENTE { get; set; }
        public string NFCE_CSC { get; set; }
        public string NFCE_IDTOKEN { get; set; }
        public string NFCE_NATUREZA_OPERACAO { get; set; }
        public int NFCE_REAJUSTE_HORARIO { get; set; }
        public bool NFCE_UTILIZAR_IMPRESSORA_NAO_FISCAL { get; set; }
        public string ATUALIZACAO_NOVIDADEATUAL { get; set; }
        public string ATUALIZACAO_NOVIDADENOVA { get; set; }
        public string ATUALIZACAO_LINKDOWNLOADATUAL { get; set; }
        public string ATUALIZACAO_LINKDOWNLOADNOVA { get; set; }
        public string ATUALIZACAO_VERSAONOVA { get; set; }
        public string ATUALIZACAO_VERSAOATUAL { get; set; }
        public bool INTERPRETADOR_CODIGOBARRA_ATIVO { get; set; }
        public int INTERPRETADOR_CODIGOBARRA_BLOCOA_QUANTIDADEDIGITOS { get; set; }
        public string INTERPRETADOR_CODIGOBARRA_BLOCOB_PRECOPESO { get; set; }
        public int INTERPRETADOR_CODIGOBARRA_BLOCOB_QUANTIDADEDIGITOS { get; set; }
        public int CONTROLESENHA { get; set; }
        public bool CONTROLESENHA_REINICIAR_NO_INICIO_DO_DIA { get; set; }
        public System.DateTime CONTROLESENHA_ULTIMA_ALTERACAO { get; set; }
        public string CONTROLESENHA_ULTIMA_ALTERACAO_USUARIO { get; set; }
        public bool CONTROLESENHA_UTILIZAR_CONTROLE { get; set; }
        public System.DateTime CONTROLESENHA_ULTIMO_REINICIO_SENHA { get; set; }
        public int JUROS_DINHEIRO_TIPO { get; set; }
        public decimal JUROS_DINHEIRO_TAXA { get; set; }
        public decimal JUROS_DINHEIRO_MULTA { get; set; }
        public int JUROS_CARTAO_TIPO { get; set; }
        public decimal JUROS_CARTAO_TAXA { get; set; }
        public decimal JUROS_CARTAO_MULTA { get; set; }
        public int JUROS_CHEQUE_TIPO { get; set; }
        public decimal JUROS_CHEQUE_TAXA { get; set; }
        public decimal JUROS_CHEQUE_MULTA { get; set; }
        public int JUROS_DUPLICATA_TIPO { get; set; }
        public decimal JUROS_DUPLICATA_TAXA { get; set; }
        public decimal JUROS_DUPLICATA_MULTA { get; set; }
        public int JUROS_PROMISSORIA_TIPO { get; set; }
        public decimal JUROS_PROMISSORIA_TAXA { get; set; }
        public decimal JUROS_PROMISSORIA_MULTA { get; set; }
        public int JUROS_BOLETO_TIPO { get; set; }
        public decimal JUROS_BOLETO_TAXA { get; set; }
        public decimal JUROS_BOLETO_MULTA { get; set; }
        public Nullable<System.DateTime> JUROS_ULTIMAATUALIZACAO { get; set; }
        public Nullable<int> PDV_TIPODESCONTO { get; set; }
        public string PDV_MENSAGEMFINALIZACAOVENDA { get; set; }
        public Nullable<bool> INTERPRETADOR_CODIGOBARRA_BLOCOB_CONVERTERPRECOPARAPESO { get; set; }
        public Nullable<System.DateTime> ULTIMO_BACKUP { get; set; }
        public bool UTILIZARDESCRICAORESUMIDANANFCE { get; set; }
        public Nullable<System.DateTime> ULTIMO_SINCRONIZACAO_PROJECTWEB_PRODUTO { get; set; }
        public Nullable<System.DateTime> ULTIMO_SINCRONIZACAO_PROJECTWEB_NOTAFISCAL { get; set; }
        public string OBSERVACAO_IMPRESSAO_CONSIGNADO { get; set; }
        public string OBSERVACAO_IMPRESSAO_TROCA_DEVOLUCAO { get; set; }
        public string OBSERVACAO_IMPRESSAO_VENDA { get; set; }
        public bool NOVAVENDA_AGRUPARPRODUTOSDEMESMOVALOR { get; set; }
        public bool NOVAVENDA_TRABALHAR_COM_PREVENDA { get; set; }
        public bool ABRIR_NOVAVENDA_AO_FINALIZAR { get; set; }
        public int JUROS_DINHEIRO_CARENCIA { get; set; }
        public int JUROS_CARTAO_CARENCIA { get; set; }
        public int JUROS_CHEQUE_CARENCIA { get; set; }
        public int JUROS_DUPLICATA_CARENCIA { get; set; }
        public int JUROS_PROMISSORIA_CARENCIA { get; set; }
        public int JUROS_BOLETO_CARENCIA { get; set; }
        public int JUROS_CARTEIRA_TIPO { get; set; }
        public decimal JUROS_CARTEIRA_TAXA { get; set; }
        public decimal JUROS_CARTEIRA_MULTA { get; set; }
        public int JUROS_CARTEIRA_CARENCIA { get; set; }
        public int NFCE_NUMERO_SERIE { get; set; }
        public int NUMERACAO_PREVENDA_TIPO { get; set; }
        public int NF_ULTIMONUMERO { get; set; }
        public int NF_DanfeModelo { get; set; }
        public decimal NF_CREDITO_ALIQUOTA { get; set; }
        public int CRT { get; set; }
        public string NF_CREDITO_CFOPs { get; set; }
        public Nullable<bool> CONTRATO_ISSOLICITAR { get; set; }
        public int FORMATODECIMAL_QUANTIDADE_COMPRA { get; set; }
        public int FORMATODECIMAL_MONETARIO_COMPRA { get; set; }
        public int FORMATODECIMAL_PORCENTAGEM_COMPRA { get; set; }
        public int JUROS_VALETICKET_TIPO { get; set; }
        public decimal JUROS_VALETICKET_TAXA { get; set; }
        public decimal JUROS_VALETICKET_MULTA { get; set; }
        public int JUROS_VALETICKET_CARENCIA { get; set; }
        public int JUROS_CARTAODEBITO_TIPO { get; set; }
        public decimal JUROS_CARTAODEBITO_TAXA { get; set; }
        public decimal JUROS_CARTAODEBITO_MULTA { get; set; }
        public int JUROS_CARTAODEBITO_CARENCIA { get; set; }
        public string CFOP_PADRAO_SAIDA { get; set; }
        public Nullable<int> LIMITE_RESULTADO_CONSULTAS { get; set; }
        public int PROTOCOLOTRANSMISSAO { get; set; }
        public string CONTADOR_EMAILS { get; set; }
        public Nullable<System.DateTime> CONTADOR_ULTIMOENVIOMOVIMENTACAO { get; set; }
        public bool COMISSAO_IS_ATIVO { get; set; }
        public decimal COMISSAO_GERAL_MOEDA { get; set; }
        public decimal COMISSAO_GERAL_PORCENTAGEM { get; set; }
        public int COMISSAO_DIA_FECHAMENTO { get; set; }
        public Nullable<System.DateTime> COMISSAO_ULTIMOENVIORELATORIOS { get; set; }
        public string WEB_TOKEN { get; set; }
        public Nullable<System.DateTime> WEB_TOKEN_DATAEXPIRACAO { get; set; }
        public bool ENVIAR_NFE_EMAIL { get; set; }
        public bool ENVIAR_NFCE_EMAIL { get; set; }
        public int CREDIARIO_TIPO { get; set; }
        public decimal CREDIARIO_TAXA { get; set; }
        public decimal CREDIARIO_MULTA { get; set; }
        public int CREDIARIO_CARENCIA { get; set; }
        public decimal CREDIARIO_ACRECIMOVALOR { get; set; }
        public decimal CREDIARIO_ACRECIMOPORCENTAGEM { get; set; }
        public decimal CREDIARIO_PARCELAMENTO_MAXIMO { get; set; }
        public decimal CREDIARIO_VALIDADE { get; set; }
        public Nullable<System.DateTime> CREDIARIO_ULTIMAATUALIZACAO { get; set; }
        public string CREDIARIO_INSTRUCAO_CARNE { get; set; }
        public int CREDIARIO_OPCAO_PRIMEIRA_PARCELA { get; set; }
        public int CREDIARIO_CONFIRMACAR_DADOS { get; set; }
        public int PEDIDO_NUMERO_COPIAS { get; set; }
        public bool ISMULTILOJA { get; set; }
        public bool ISPRORROGARBLOQUEIO { get; set; }
        public bool PRIMEIRO_LEMBRETE_FATURA { get; set; }
        public bool SEGUNDO_LEMBRETE_FATURA { get; set; }
        public bool TERCEIRO_LEMBRETE_FATURA { get; set; }
        public decimal ALIQUOTA_PIS { get; set; }
        public decimal ALIQUOTA_COFINS { get; set; }
        public decimal ALIQUOTA_ICMS { get; set; }
        public string CFOP_NFC { get; set; }
        public string CFOP_NF { get; set; }
        public string TOKEN_DEOLHONOIMPOSTO { get; set; }
        public string CST_NFC { get; set; }
        public string COD_BENEFICIO_FISCAL_NFC { get; set; }
        public string CST_NF_CONS_FINAL { get; set; }
        public string COD_BENEFICIO_FISCAL_NF_CONS_FINAL { get; set; }
        public string CST_NF_CONS_NAO_FINAL { get; set; }
        public string COD_BENEFICIO_FISCAL_NF_CONS_NAO_FINAL { get; set; }
        public int DIAS_VENCIMENTO_CERTIFICADO { get; set; }
        public string XML_EXTRAIR { get; set; }
        public Nullable<int> XML_MESES_MANTER { get; set; }
        public Nullable<int> CST_COFINS { get; set; }
        public Nullable<int> CST_PIS { get; set; }
        public string EMAIL_SERVIDORSMTP { get; set; }
        public string EMAIL_USUARIO { get; set; }
        public string EMAIL_SENHA { get; set; }
        public string EMAIL_PORTA { get; set; }
        public int EMAIL_CRIPTOGRAFIA { get; set; }
        public bool EMAIL_AUTENTICARSSL { get; set; }
        public bool MOSTRAR_UNIDADE { get; set; }
        public Nullable<System.DateTime> DATAPRORROGARBLOQUEIOS { get; set; }
        public string DATABLOQUEIOS { get; set; }
        public Nullable<int> DIASTOLERANCIA { get; set; }
        public Nullable<System.DateTime> DATAATUALIZACAO { get; set; }
        public int EXIBIR_NA_IMPRESSAO { get; set; }
        public System.DateTime ULTIMOMDELETELOG { get; set; }
        public int DIASDELETARLOG { get; set; }
        public int NUMERO_COBRANCA_CARTAODECREDITO { get; set; }
        public int NUMERO_COBRANCA_PROMISSORIA { get; set; }
        public int NUMERO_COBRANCA_TRANSFERENCIA { get; set; }
        public int NUMERO_COBRANCA_CARTEIRA { get; set; }
        public int NUMERO_COBRANCA_CHEQUE { get; set; }
        public int NUMERO_COBRANCA_CREDIARIO { get; set; }
        public int NUMERO_COBRANCA_DUPLICATA { get; set; }
        public bool VALORTOTALPROMISSORIA { get; set; }
        public int NUMERO_COBRANCA_BOLETO { get; set; }
        public bool ISIMPRESSAOPARCELASNOTA { get; set; }
        public bool DESABILITARGTIN { get; set; }
        public bool FRETE_PROPORCIONAL { get; set; }
        public bool ISIMAGEMPEDIDO { get; set; }
        public bool ISVALORATACADO { get; set; }
        public bool UTILIZAR_CODIGO_EAN13 { get; set; }
        public Nullable<System.DateTime> HUB_ESTOQUEENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_PRODUTOENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_PRODUTORECEBER { get; set; }
        public Nullable<System.DateTime> HUB_GRADERECEBER { get; set; }
        public Nullable<System.DateTime> HUB_GRADEENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_GRUPOENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_PEDIDORECEBER { get; set; }
        public Nullable<System.DateTime> HUB_PEDIDOENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_PESSOAENVIAR { get; set; }
        public Nullable<System.DateTime> HUB_PESSOARECEBER { get; set; }
        public bool TICKET_MEDIO_COMPRA { get; set; }
        public string API_URL { get; set; }
        public string API_CODE { get; set; }
        public bool VINCULARSUBGRUPOCOMGRUPO { get; set; }
        public bool ENVIAR_CATEGORIA { get; set; }
        public bool ENVIAR_PRODUTO { get; set; }
        public bool RECEBER_PRODUTO { get; set; }
        public bool ENVIAR_CLIENTE { get; set; }
        public bool RECEBER_CLIENTE { get; set; }
        public bool RECEBER_PEDIDO { get; set; }
        public Nullable<System.DateTime> ULTIMASINCRONIZACAO_HUB { get; set; }
        public string OBSERVACAO_IMPRESSAO_NOTA { get; set; }
        public bool UTILIZAR_NOVA_TELA_BUSCA { get; set; }
        public bool UTILIZAR_CODIGOPRIMARIO_CONDICIONAL { get; set; }
        public bool CONDICIONAL_MOSTRAR_UNIDADE { get; set; }
        public int CONDICIONAL_NUMERO_COPIAS { get; set; }
        public bool UTILIZAR_CUSTO_MEDIO_COMPRA { get; set; }
    }
}
