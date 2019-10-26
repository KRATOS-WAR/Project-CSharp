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
using System.Reflection;

namespace Apresentacao
{
    public partial class FrmClientePesquisar : Form
    {
        public Cliente clienteSelecionado { get; set; }

        public FrmClientePesquisar()
        {
            InitializeComponent();

            dgwPrincipal.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            //Digitou número ou nome?
            ClienteColecao clienteColecao = new ClienteColecao();

            int codigoDigitado;
            if (int.TryParse(txtPesquisar.Text, out codigoDigitado) == true)
            {
                //Conseguiu, é um número
                clienteColecao = clienteNegocios.Consultar(codigoDigitado, null);
            }
            else
            {
                //Não conseguiu, é um texto
                clienteColecao = clienteNegocios.Consultar(null, txtPesquisar.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = clienteColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }

        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                if (nomeDaPropriedade.Contains("."))
                {
                    //Pessoa.IDPessoa
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno =
                                    CarregarPropriedade
                                    (
                                        propertyInfo.GetValue(propriedade, null),
                                        nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1)
                                    );
                            }
                        }
                    }
                }
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;

                    if (propriedade != null)
                    {
                        tpyPropertyType = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dgwPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwPrincipal.Rows[e.RowIndex].DataBoundItem != null) && (dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgwPrincipal.Rows[e.RowIndex].DataBoundItem, dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.Rows.Count < 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. ");
                return;
            }

            clienteSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as Cliente;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
