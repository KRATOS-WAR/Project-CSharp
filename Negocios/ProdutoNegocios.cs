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
    public class ProdutoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CodigoProduto", produto.CodigoProduto);
                acessoDados.AdicionarParametros("@Descricao", produto.Descricao);
                acessoDados.AdicionarParametros("@MarcaFabricante", produto.MarcaFabricante);
                acessoDados.AdicionarParametros("@UnidadeMedida", produto.UnidadeMedida);
                acessoDados.AdicionarParametros("@PrecoUnitario", produto.PrecoUnitario);

                string idProduto = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspProdutoInserir").ToString();

                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ProdutoColecao Consultar(int? idProduto, string descricao)
        {
            ProdutoColecao produtoColecao = new ProdutoColecao();

            acessoDados.LimparParametros();

            if (idProduto != null)
            {
                acessoDados.AdicionarParametros("@IDProduto", idProduto);
            }

            if (descricao != null)
            {
                acessoDados.AdicionarParametros("@Descricao", descricao);
            }

            DataTable dataTable = acessoDados.ExecutarConsulta(
                    CommandType.StoredProcedure, "uspProdutoConsultarPorCodigoDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();

                produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                produto.Descricao= Convert.ToString(dataRow["Descricao"]);

                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }
    }
}
