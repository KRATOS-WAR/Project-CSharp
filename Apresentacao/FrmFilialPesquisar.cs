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
    public partial class FrmFilialPesquisar : Form
    {
        public FrmFilialPesquisar()
        {
            InitializeComponent();
        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FilialNegocios FilialNegocios = new FilialNegocios();

            //Digitou número ou nome?
            int codigoDigitado;
            FilialColecao filialColecao = new FilialColecao();

            if (int.TryParse(txtPesquisar.Text, out codigoDigitado) == true)
            {
                //Conseguiu, é um número
                filialColecao = FilialNegocios.ConsultarPorCodigo(codigoDigitado);
            }
            else{
                //Não conseguiu, é um texto
                filialColecao = FilialNegocios.ConsultarPorNome(txtPesquisar.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = filialColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
    }
}
