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
    public class PessoaJuridicaNegocios
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

        public string Inserir(PessoaJuridica pessoaJuridica)
        {
            try
            {
                acessoDados.LimparParametros();

                acessoDados.AdicionarParametros("@NomeFantasia", pessoaJuridica.NomeFantasia);
                acessoDados.AdicionarParametros("@RazaoSocial", pessoaJuridica.RazaoSocial);
                acessoDados.AdicionarParametros("@CNPJ", pessoaJuridica.CNPJ);
                acessoDados.AdicionarParametros("@InscricaoEstadual", pessoaJuridica.InscricaoEstadual);
                acessoDados.AdicionarParametros("@DataFundacao", pessoaJuridica.DataFundacao);

                string idPessoaJuridica = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();

                return idPessoaJuridica;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
