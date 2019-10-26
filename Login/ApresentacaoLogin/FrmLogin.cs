﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Login.Apresentacao;
using Login.Modelo;
using Apresentacao;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            FrmCadastrarLogin frmCadastrarLogin = new FrmCadastrarLogin();
            frmCadastrarLogin.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado Com Sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
