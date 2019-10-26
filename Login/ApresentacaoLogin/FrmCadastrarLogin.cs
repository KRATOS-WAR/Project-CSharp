using Login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Apresentacao
{
    public partial class FrmCadastrarLogin : Form
    {
        public FrmCadastrarLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtLogin.Text, txtSenha.Text, txtConfirmarSenha.Text);

            if (controle.tem)//Mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.mensagem); //Mensagem de erro
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
