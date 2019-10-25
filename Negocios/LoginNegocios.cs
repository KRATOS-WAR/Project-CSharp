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
    public class LoginNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string InserirLogin(Login login)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Usuario", login.Usuario);
                acessoDados.AdicionarParametros("@Senha", login.Senha);

                string idLogin = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspLoginInserir").ToString();

                return idLogin;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
