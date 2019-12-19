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
    public partial class FrmPessoaJuridicaCadastrar : Form
    {
        public FrmPessoaJuridicaCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            pessoaJuridica.NomeFantasia = txtNomeFantasia.Text;
            pessoaJuridica.RazaoSocial = txtRazaoSocial.Text;
            pessoaJuridica.CNPJ = txtInscricaoEstadual.Text;
            pessoaJuridica.InscricaoEstadual = txtInscricaoEstadual.Text;
            pessoaJuridica.DataFundacao = Convert.ToDateTime(dtpDataFundacao.Value);

            PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

            string retorno = pessoaJuridicaNegocios.Inserir(pessoaJuridica);

            //Tenta converter para inteiro
            //Se der tudo certo é porque devolveu o código do cliente
            //Se der errado tem a mensagem de erro
            try
            {
                int idPessoa = Convert.ToInt32(retorno);

                MessageBox.Show("Pessoa Jurídica inserida com sucesso! Código: " + idPessoa.ToString());

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show(
                "Não foi possível inserir a Pessoa Jurídica. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
