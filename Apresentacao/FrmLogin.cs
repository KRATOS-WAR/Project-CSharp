using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmLoginCadastrar FrmLoginCadastrar = new FrmLoginCadastrar();
            FrmLoginCadastrar.ShowDialog();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if ((txtUsuario.Text.Equals(login.Usuario)) && (txtSenha.Text.Equals(login.Senha)))
            {
                MessageBox.Show("Seja Bem Vindo");
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
