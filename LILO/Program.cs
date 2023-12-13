using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionario();
            cliente();
            cliente2();
            produto();

        }

        private static void produto()
        {
            Origem.LiloEntities origem = new Origem.LiloEntities();

            Destino.virgemEntities destino = new Destino.virgemEntities();

            int i = 1;
            int count = origem.Cad_prod.Count();

            foreach (var antProd in origem.Cad_prod.ToList())
            {
                Destino.produto novoProd = new Destino.produto();

                novoProd.DESCRICAO = antProd.Descricao;
                novoProd.NCM = antProd.NCM;
                novoProd.VALOR_CUSTO = (decimal)antProd.PrecoCustoR;
                novoProd.VALOR_VENDA_VAREJO = (decimal)antProd.PrecoVendaVarR;
                novoProd.REFERENCIAPADRAO = antProd.CodFrabrica;
                novoProd.REFERENCIAPRODUTO = antProd.CodBarras;
                novoProd.ISATIVO = true;
                novoProd.ALTERACAODATA = DateTime.Now;
                novoProd.ALTERACAOUSUARIO = "IMPORTAÇÃO";
                novoProd.CFOP = antProd.CFOP;
                novoProd.CSOSNCST = antProd.CSOSN.Replace("csosn", "");
                novoProd.ESTOQUEPRODUTO = (decimal)antProd.QtdEstoque;

                destino.produto.Add(novoProd);
                destino.SaveChanges();
                i++;



            }
        }


        private static void funcionario()
        {
            Origem.LiloEntities origem = new Origem.LiloEntities();

            Destino.virgemEntities destino = new Destino.virgemEntities();

            int i = 1;
            int count = origem.Cad_Func.Count();

            foreach (var antFun in origem.Cad_Func.ToList())
            {
                Destino.pessoa novoFun = new Destino.pessoa();

                novoFun.ISFUNCIONARIO = true;
                novoFun.NOMERAZAOSOCIAL = antFun.Nome;
                novoFun.NOMEFANTASIA = antFun.Cargo;
                novoFun.TRABALHOCARGO = antFun.Cargo;
                novoFun.DATAADMISSAO = antFun.DataAdmissao;
                novoFun.ALTERACAODATA = DateTime.Now;
                novoFun.ALTERACAOUSUARIO = "IMPORTAÇÃO";
                novoFun.ATIVO = true;
                novoFun.CADASTROCOMPLETO = true;
                novoFun.DESCONTOMAXIMOPERMITIDO = 100;
                novoFun.CONTRIBUINTE = 0;
                novoFun.CONSUMIDORFINAL = 1;
                novoFun.PAIS_ID = 30;

                destino.pessoa.Add(novoFun);
                destino.SaveChanges();
                i++;

            }
        }

        private static void cliente()
        {
            Origem.LiloEntities origem = new Origem.LiloEntities();

            Destino.virgemEntities destino = new Destino.virgemEntities();

            int i = 1;
            int count = origem.Cli_Fornec.Count();

            foreach (var antCli in origem.Cli_Fornec.ToList())
            {
                Destino.pessoa novoCli = new Destino.pessoa();

                novoCli.ISCLIENTE = true;
                novoCli.ISFORNECEDOR = true;
                novoCli.NOMERAZAOSOCIAL = antCli.Nome;
                novoCli.NOMEFANTASIA = antCli.RazaoSocial;
                novoCli.ALTERACAODATA = DateTime.Now;
                novoCli.ALTERACAOUSUARIO = "IMPORTAÇÃO";
                novoCli.ATIVO = true;
                novoCli.CADASTROCOMPLETO = true;
                novoCli.DESCONTOMAXIMOPERMITIDO = 100;
                novoCli.PAIS_ID = 30;

                novoCli.CONTRIBUINTE = antCli.RG_InscEst != null? 1 : 0;
                novoCli.CONSUMIDORFINAL = novoCli.CONTRIBUINTE == 1? 0 : 1;


                novoCli.FISJUR = antCli.Pessoa == "Física" ? "F" : "J";
                novoCli.CPFCNPJ = antCli.CPF_CNPJ;
                novoCli.RGIE = antCli.RG_InscEst;
                novoCli.OBSERVACAO = antCli.Observacao;
                novoCli.LOGRADOURO = antCli.Endereco;
                novoCli.CEP = antCli.CEP;
                novoCli.CELULAR = antCli.Celular;
                novoCli.NUMERO = antCli.Numero;
                novoCli.DATACADASTRO = antCli.DataCadastro;
                novoCli.COMPLEMENTO = antCli.Complemento;
                novoCli.BAIRRO = antCli.Bairro;
                novoCli.TELEFONE = antCli.Fone1;

                destino.pessoa.Add(novoCli);
                destino.SaveChanges();
                i++;

            }
        }

        private static void cliente2()
        {
            Origem.LiloEntities origem = new Origem.LiloEntities();

            Destino.virgemEntities destino = new Destino.virgemEntities();

            int i = 1;
            int count = origem.Cli_Fornec2.Count();

            foreach (var antCli in origem.Cli_Fornec2.ToList())
            {
                Destino.pessoa novoCli = new Destino.pessoa();

                novoCli.ISCLIENTE = true;
                novoCli.ISFORNECEDOR = true;
                novoCli.NOMERAZAOSOCIAL = antCli.Nome;
                novoCli.NOMEFANTASIA = antCli.RazaoSocial;
                novoCli.ALTERACAODATA = DateTime.Now;
                novoCli.ALTERACAOUSUARIO = "IMPORTAÇÃO";
                novoCli.ATIVO = true;
                novoCli.CADASTROCOMPLETO = true;
                novoCli.DESCONTOMAXIMOPERMITIDO = 100;
                novoCli.PAIS_ID = 30;

                novoCli.CONTRIBUINTE = antCli.RG_InscEst != null ? 1 : 0;
                novoCli.CONSUMIDORFINAL = novoCli.CONTRIBUINTE == 1 ? 0 : 1;


                novoCli.FISJUR = antCli.Pessoa == "Física" ? "F" : "J";
                novoCli.CPFCNPJ = antCli.CPF_CNPJ;
                novoCli.RGIE = antCli.RG_InscEst;
                novoCli.OBSERVACAO = antCli.Observacao;
                novoCli.LOGRADOURO = antCli.Endereco;
                novoCli.CEP = antCli.CEP;
                novoCli.CELULAR = antCli.Celular;
                novoCli.BAIRRO = antCli.Bairro;
                novoCli.TELEFONE = antCli.Fone1;

                destino.pessoa.Add(novoCli);
                destino.SaveChanges();
                i++;

            }
        }
    }
}
 