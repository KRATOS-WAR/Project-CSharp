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

using Login.DAL;
using static Login.DAL.ChecarForcaSenha;

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

            ChecarForcaSenha verifica = new ChecarForcaSenha();
            int placar;

            //if ((placar < 50) && (placar < 60))
            //{

           // }

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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != string.Empty)
            {
                ChecarForcaSenha verifica = new ChecarForcaSenha();
                int placar;
                ForcaDaSenha forca;

                placar = verifica.geraPontosSenha(txtSenha.Text);
                forca = verifica.GetForcaDaSenha(txtSenha.Text);

                //lblPontosSenha.Text = placar.ToString() + " Pontos";

                if (placar < 50) {
                    txtForcaSenha.ForeColor = Color.Red;
                    txtForcaSenha.Text = "Senha Inaceitável!";
                }
                else if (placar < 60) {
                    txtForcaSenha.ForeColor = Color.Orange;
                    txtForcaSenha.Text = "Senha Fraca!";
                }
                else if (placar < 80) {
                    txtForcaSenha.ForeColor = Color.Yellow;
                    txtForcaSenha.Text = "Senha Aceitável!";
                }
                else if (placar < 100) {
                    txtForcaSenha.ForeColor = Color.Green;
                    txtForcaSenha.Text = "Senha Forte!";
                }
                else {
                    txtForcaSenha.ForeColor = Color.Blue;
                    txtForcaSenha.Text = "Senha Segura!";
                }
            }
        }
    }
}
