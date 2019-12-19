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
    public partial class FrmPessoaFisicaCadastrar : Form
    {
        public FrmPessoaFisicaCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();

            pessoaFisica.Nome = txtNome.Text;
            pessoaFisica.RG = txtRG.Text;
            pessoaFisica.CPF = txtCPF.Text;
            pessoaFisica.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Value);

            PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();

            string retorno = pessoaFisicaNegocios.Inserir(pessoaFisica);

            //Tenta converter para inteiro
            //Se der tudo certo é porque devolveu o código do cliente
            //Se der errado tem a mensagem de erro
            try
            {
                int idPessoa = Convert.ToInt32(retorno);

                MessageBox.Show("Pessoa Física inserida com sucesso! Código: " + idPessoa.ToString());

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show(
                "Não foi possível inserir a pessoa. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
