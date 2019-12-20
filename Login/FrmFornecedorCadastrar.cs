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
    public partial class FrmFornecedorCadastrar : Form
    {
        public FrmFornecedorCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Descricao = txtDescricao.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmail.Text;

            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();

            string retorno = fornecedorNegocios.Inserir(fornecedor);

            //Tenta converter para inteiro
            //Se der tudo certo é porque devolveu o código do cliente
            //Se der errado tem a mensagem de erro
            try
            {
                int idFornecedor = Convert.ToInt32(retorno);

                MessageBox.Show("Fornecedor inserido com sucesso! Código: " + idFornecedor.ToString());

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show(
                "Não foi possível inserir o Fornecedor. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
