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
    public partial class FrmFilialCadastrar : Form
    {
        public FrmFilialCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Filial filial = new Filial();

            filial.CodigoFilial = Convert.ToInt32(txtCodigo.Text);
            filial.CNPJFilial = txtCNPJ.Text;
            filial.DescricaoFilial = txtDescricao.Text;

            FilialNegocios filialNegocios = new FilialNegocios();

            string retorno = filialNegocios.Inserir(filial);

            //Tenta converter para inteiro
            //Se der tudo certo é porque devolveu o código do cliente
            //Se der errado tem a mensagem de erro
            try
            {
                int idFilial = Convert.ToInt32(retorno);

                MessageBox.Show("Filial inserida com sucesso! Código: " + idFilial.ToString());

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show(
                "Não foi possível inserir a Filial. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
