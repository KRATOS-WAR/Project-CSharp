using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class FilialNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Filial filial)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CodigoFilial", filial.CodigoFilial);
                acessoDados.AdicionarParametros("@CNPJFilial", filial.CNPJFilial);
                acessoDados.AdicionarParametros("@DescricaoFilial", filial.DescricaoFilial);

                string idFilial = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspFilialInserir").ToString();

                return idFilial;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //public FilialColecao ConsultarPorCodigo(int idPessoaFilial)
        //{
        //    try
        //    {
        //        FilialColecao filialColecao = new FilialColecao();

        //        acessoDados.LimparParametros();
        //        acessoDados.AdicionarParametros("@IDPessoaFilial", idPessoaFilial);

        //        DataTable dataTable = acessoDados.ExecutarConsulta(
        //            CommandType.StoredProcedure, "uspFilialConsultarPorCodigo");

        //        foreach (DataRow dataRow in dataTable.Rows)
        //        {
        //            Filial filial = new Filial();

        //            filial.Pessoa = new Pessoa();
        //            filial.Pessoa.IDPessoa = Convert.ToInt32(dataRow["IDPessoaFilial"]);
        //            filial.Pessoa.Nome = Convert.ToString(dataRow["Nome"]);
        //            filial.Pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

        //            filial.Pessoa.PessoaTipo = new PessoaTipo();
        //            filial.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
        //            filial.Pessoa.PessoaTipo.Descricao = Convert.ToString(dataRow["DescricaoTipo"]);

        //            filialColecao.Add(filial);
        //        }

        //        return filialColecao;
        //    }
        //    catch (Exception erroOcorrido)
        //    {
        //        throw new Exception("Erro ao consultar filial por código. Detalhes: " +
        //            erroOcorrido.Message);
        //    }
        //}

        //public FilialColecao ConsultarPorNome(string nome)
        //{
        //    try
        //    {
        //        FilialColecao filialColecao = new FilialColecao();

        //        acessoDados.LimparParametros();
        //        acessoDados.AdicionarParametros("@Nome", nome);

        //        DataTable dataTable = acessoDados.ExecutarConsulta(
        //            CommandType.StoredProcedure, "uspFilialConsultarPorNome");

        //        foreach (DataRow dataRow in dataTable.Rows)
        //        {
        //            Filial filial = new Filial();

        //            filial.Pessoa = new Pessoa();
        //            filial.Pessoa.IDPessoa = Convert.ToInt32(dataRow["IDPessoaFilial"]);
        //            filial.Pessoa.Nome = Convert.ToString(dataRow["Nome"]);
        //            filial.Pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

        //            filial.Pessoa.PessoaTipo = new PessoaTipo();
        //            filial.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
        //            filial.Pessoa.PessoaTipo.Descricao = Convert.ToString(dataRow["DescricaoTipo"]);

        //            filialColecao.Add(filial);
        //        }

        //        return filialColecao;
        //    }
        //    catch (Exception erroOcorrido)
        //    {
        //        throw new Exception("Erro ao consultar filial por nome. Detalhes: " +
        //            erroOcorrido.Message);
        //    }
        //}
    }
}
