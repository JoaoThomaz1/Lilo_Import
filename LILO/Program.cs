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
    }
}
 