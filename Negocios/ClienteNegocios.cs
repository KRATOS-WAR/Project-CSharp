using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //public ClienteColecao Consultar(int? idPessoaCliente, string nome)
        //{
        //    ClienteColecao clienteColecao = new ClienteColecao();

        //    acessoDados.LimparParametros();

        //    if (idPessoaCliente != null)
        //    {
        //        acessoDados.AdicionarParametros("@IDPessoaCliente", idPessoaCliente);
        //    }

        //    if (nome != null)
        //    {
        //        acessoDados.AdicionarParametros("@Nome", nome);
        //    }

        //    DataTable dataTable = acessoDados.ExecutarConsulta(
        //            CommandType.StoredProcedure, "uspClienteConsultarPorCodigoNome");

        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        Cliente cliente = new Cliente();

        //        cliente.Pessoa = new Pessoa();
        //        cliente.IDPessoacliente = Convert.ToInt32(dataRow["IDPessoaCliente"]);
        //        cliente.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
        //        cliente.Pessoa.Nome = Convert.ToString(dataRow["Nome"]);
        //        cliente.Pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

        //        clienteColecao.Add(cliente);
        //    }

        //    return clienteColecao;
        //}

        public string Inserir(Cliente cliente)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", cliente.Nome);
                acessoDados.AdicionarParametros("@CpfCnpj", cliente.CpfCnpj);
                acessoDados.AdicionarParametros("@RG", cliente.RG);
                acessoDados.AdicionarParametros("@Endereco", cliente.Endereco);
                acessoDados.AdicionarParametros("@Celular", cliente.Celular);
                acessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);

                string idCliente = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
