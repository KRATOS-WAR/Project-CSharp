﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apresentacao;
using Login.DAL;
using AcessoBancoDados;
using System.Data;

namespace Login.DAL
{
    public class LoginDalComandos
    {
        public bool tem = false;
        public String mensagem = "";//Tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr;
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public bool verificarLogin(String login, String senha)
        {
            //Procurar no banco esse login e senha
            cmd.CommandText = "SELECT * FROM tblLogin WHERE Usuario = @Usuario AND Senha = @Senha";
            cmd.Parameters.AddWithValue("@Usuario", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)//Se foi encontrado
                {
                    tem = true;
                }
                conexao.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados";
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //Comandos para inserir
            if (senha.Equals(confSenha))
            {
                //cmd.CommandText = "INSERT INTO tblLogin VALUES (@e, @s);";
                //cmd.Parameters.AddWithValue("@e", email);
                //cmd.Parameters.AddWithValue("@s", senha);
               
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Usuario", email);
                acessoDados.AdicionarParametros("@Senha", senha);

                string idLogin = acessoDados.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspLoginInserir").ToString();

                mensagem = idLogin; 


                try
                {
                    cmd.Connection = conexao.Conectar();
                    //cmd.ExecuteNonQuery();                  

                    if(mensagem == "Login já existe")
                    {
                        conexao.Desconectar();
                        this.mensagem = "Usuário já existe. Por favor insira outro!!";
                        tem = false;
                    }
                    else
                    {
                        conexao.Desconectar();
                        this.mensagem = "Cadastrado com Sucesso";
                        tem = true;
                    }

                    
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }

            return mensagem;
        }
    }
}
