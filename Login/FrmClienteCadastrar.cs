﻿using System;
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
    public partial class FrmClienteCadastrar : Form
    {
        public FrmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.CpfCnpj = txtCpfCnpj.Text;
                cliente.RG = txtRG.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Celular = txtCelular.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDatanascimento.Value);

                ClienteNegocios clienteNegocios = new ClienteNegocios();

                string retorno = clienteNegocios.Inserir(cliente);

                //Tenta converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro
                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente inserido com sucesso! Código: " + idCliente.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show(
                    "Não foi possível inserir o cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
