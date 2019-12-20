using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Login
{
    public partial class FrmProdutoCadastrar : Form
    {
        public FrmProdutoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.CodigoProduto = Convert.ToInt32(txtCodigo.Text);
            produto.Descricao = txtDescricao.Text;
            produto.MarcaFabricante = txtMarcaFabricante.Text;
            produto.UnidadeMedida = cbxUnidadeMedida.Text;
            produto.PrecoUnitario = Convert.ToDecimal(txtPrecoVenda.Text);

            ProdutoNegocios produtoNegocios = new ProdutoNegocios();

            string retorno = produtoNegocios.Inserir(produto);

            //Tenta converter para inteiro
            //Se der tudo certo é porque devolveu o código do cliente
            //Se der errado tem a mensagem de erro
            try
            {
                int idProduto = Convert.ToInt32(retorno);

                MessageBox.Show("Produto inserido com sucesso! Código: " + idProduto.ToString());

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show(
                "Não foi possível inserir o Produto. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
