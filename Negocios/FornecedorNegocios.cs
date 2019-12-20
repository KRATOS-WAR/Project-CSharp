using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class FornecedorNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                acessoDados.AdicionarParametros("@Descricao", fornecedor.Descricao);
                acessoDados.AdicionarParametros("@Endereco", fornecedor.Endereco);
                acessoDados.AdicionarParametros("@Telefone", fornecedor.Telefone);
                acessoDados.AdicionarParametros("@Email", fornecedor.Email);

                string idFornecedor = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspFornecedorInserir").ToString();

                return idFornecedor;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //public ProdutoColecao Consultar(int? idProduto, string descricao)
        //{
        //    ProdutoColecao produtoColecao = new ProdutoColecao();

        //    acessoDados.LimparParametros();

        //    if (idProduto != null)
        //    {
        //        acessoDados.AdicionarParametros("@IDProduto", idProduto);
        //    }

        //    if (descricao != null)
        //    {
        //        acessoDados.AdicionarParametros("@Descricao", descricao);
        //    }

        //    DataTable dataTable = acessoDados.ExecutarConsulta(
        //            CommandType.StoredProcedure, "uspProdutoConsultarPorCodigoDescricao");

        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        Produto produto = new Produto();

        //        produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
        //        produto.Descricao= Convert.ToString(dataRow["Descricao"]);

        //        produtoColecao.Add(produto);
        //    }

        //    return produtoColecao;
        //}
    }
}
