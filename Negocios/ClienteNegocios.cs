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

        public ClienteColecao Consultar(int? idPessoaCliente, string nome)
        {
            ClienteColecao clienteColecao = new ClienteColecao();

            acessoDados.LimparParametros();

            if(idPessoaCliente != null)
            {
                acessoDados.AdicionarParametros("@IDPessoaCliente", idPessoaCliente);
            }

            if (nome != null)
            {
                acessoDados.AdicionarParametros("@Nome", nome);
            }

            DataTable dataTable = acessoDados.ExecutarConsulta(
                    CommandType.StoredProcedure, "uspClienteConsultarPorCodigoNome");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();

                cliente.Pessoa = new Pessoa();
                cliente.Pessoa.IDPessoa = Convert.ToInt32(dataRow["IDPessoaCliente"]);
                cliente.Pessoa.Nome = Convert.ToString(dataRow["Nome"]);
                cliente.Pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

                cliente.Pessoa.PessoaTipo = new PessoaTipo();
                cliente.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaTipo"]);
                cliente.Pessoa.PessoaTipo.Descricao = Convert.ToString(dataRow["DescricaoTipo"]);

                clienteColecao.Add(cliente);
            }

            return clienteColecao;
        }
    }
}
