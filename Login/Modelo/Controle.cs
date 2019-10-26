using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Login.DAL;

namespace Login.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDalComandos loginDalComandos = new LoginDalComandos();
            tem = loginDalComandos.verificarLogin(login, senha);

            if (!loginDalComandos.mensagem.Equals(""))
            {
                this.mensagem = loginDalComandos.mensagem;
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDalComandos loginDalComandos = new LoginDalComandos();
            this.mensagem = loginDalComandos.cadastrar(email, senha, confSenha);

            if (loginDalComandos.tem)//A mensagem que vai vir é de sucesso
            {
                this.tem = true;
            }

            return mensagem;
        }
    }
}
