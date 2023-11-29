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
                novoCli.CONTRIBUINTE = 0;
                novoCli.CONSUMIDORFINAL = 1;
                novoCli.PAIS_ID = 30;

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

                if (novoCli.FISJUR === "J")
                {
                    novoCli.CONTRIBUINTE = 1;
                    novoCli.CONSUMIDORFINAL = 0;
                }

                destino.pessoa.Add(novoCli);
                destino.SaveChanges();
                i++;

            }
        }
    }
}
 