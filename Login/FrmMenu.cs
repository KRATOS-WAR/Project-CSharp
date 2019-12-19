using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Login;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            //this.Visible = false;
            //FrmLogin login = new FrmLogin();
            //login.ShowDialog(this);
            //this.Visible = true;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPedido_Click(object sender, EventArgs e)
        {
            FrmPedidoVendaCadastrar frmPedidoVendaCadastrar = new FrmPedidoVendaCadastrar();
            frmPedidoVendaCadastrar.MdiParent = this;
            frmPedidoVendaCadastrar.Show();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar();
            frmClienteCadastrar.MdiParent = this;
            frmClienteCadastrar.Show();

        }

        private void menuPessoaFisica_Click(object sender, EventArgs e)
        {
            FrmPessoaFisicaCadastrar frmPessoaFisicaCadastrar = new FrmPessoaFisicaCadastrar();
            frmPessoaFisicaCadastrar.MdiParent = this;
            frmPessoaFisicaCadastrar.Show();
        }

        private void menuPessoaJuridica_Click(object sender, EventArgs e)
        {
            FrmPessoaJuridicaCadastrar frmPessoaJuridicaCadastrar = new FrmPessoaJuridicaCadastrar();
            frmPessoaJuridicaCadastrar.MdiParent = this;
            frmPessoaJuridicaCadastrar.Show();
        }
    }
}
