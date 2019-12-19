using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class PessoaFisicaNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //public PessoaColecao Consultar(int? idPessoa, string nome)
        //{
        //    ClienteColecao clienteColecao = new ClienteColecao();

        //    acessoDados.LimparParametros();

        //    if (idPessoa != null)
        //    {
        //        acessoDados.AdicionarParametros("@IDPessoa", idPessoa);
        //    }

        //    if (nome != null)
        //    {
        //        acessoDados.AdicionarParametros("@Nome", nome);
        //    }

        //    DataTable dataTable = acessoDados.ExecutarConsulta(
        //            CommandType.StoredProcedure, "uspPessoaConsultarPorCodigoNome");

        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        Pessoa pessoa = new Pessoa();
        //        PessoaColecao pessoaColecao = new PessoaColecao();

        //        pessoa.IDPessoa = Convert.ToInt32(dataRow["IDPessoa"]);
        //        pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
        //        pessoa.Nome = Convert.ToString(dataRow["Nome"]);
        //        pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

        //        pessoaColecao.Add(pessoa);
        //    }

        //    return null; //pessoaColecao
        //}

        public string Inserir(PessoaFisica pessoaFisica)
        {
            try
            {
                acessoDados.LimparParametros();

                acessoDados.AdicionarParametros("@Nome", pessoaFisica.Nome);
                acessoDados.AdicionarParametros("@RG", pessoaFisica.RG);
                acessoDados.AdicionarParametros("@CPF", pessoaFisica.CPF);
                acessoDados.AdicionarParametros("@DataNascimento", pessoaFisica.DataNascimento);

                string idPessoaFisica = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspPessoaFisicaInserir").ToString();

                return idPessoaFisica;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
