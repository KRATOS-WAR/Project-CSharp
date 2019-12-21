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
using Login;

namespace Apresentacao
{
    public partial class FrmPedidoVendaCadastrar : Form
    {

        Filial filialEmitente;
        Cliente clienteDestinatario;
        Produto produtoPesquisado;

        public FrmPedidoVendaCadastrar()
        {
            InitializeComponent();
        }

        private void FrmPedidoVendaCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lblPercentualDesconto_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarEmitente_Click(object sender, EventArgs e)
        {
            FrmFilialPesquisar frmFilialPesquisar = new FrmFilialPesquisar();
            DialogResult resultado = frmFilialPesquisar.ShowDialog();

            if(resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtEmitente.Text = frmFilialPesquisar.filialSelecionada.DescricaoFilial;

                filialEmitente = frmFilialPesquisar.filialSelecionada;
            }
        }

        private void txtEmitente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtEmitente.Clear();
                filialEmitente = null;
            }
        }

        private void btnPesquisarDestinatario_Click(object sender, EventArgs e)
        {
            FrmClientePesquisar frmClientePesquisar = new FrmClientePesquisar();

            DialogResult resultado = frmClientePesquisar.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinatario.Text = frmClientePesquisar.clienteSelecionado.Nome;

                clienteDestinatario = frmClientePesquisar.clienteSelecionado;
            }
        }

        private void txtDestinatario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtDestinatario.Clear();
                clienteDestinatario = null;
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoPesquisar frmProdutoPesquisar = new FrmProdutoPesquisar();

            DialogResult resultado = frmProdutoPesquisar.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtProdutoCodigo.Text = Convert.ToString(frmProdutoPesquisar.produtoSelecionado.IDProduto);             
                txtProduto.Text = frmProdutoPesquisar.produtoSelecionado.Descricao;

                produtoPesquisado = frmProdutoPesquisar.produtoSelecionado;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
