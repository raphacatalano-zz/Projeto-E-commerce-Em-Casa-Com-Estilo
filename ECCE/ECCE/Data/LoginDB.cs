using ECCE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Classes;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ECCE.Data
{
    public class LoginDB
    {
        public bool InserirDados(tb_login obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_login(nome, email, telefone, cpf_cnpj, senha, tipo, datacadastro, ativo) values " +
                    "(@nome, @email, @telefone, @cpf_cnpj, @senha, 'C', Now(), 1)";
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool UpDateDadosUsuario(tb_login obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_login set nome=@nome, email=@email, telefone=@telefone, cpf_cnpj@cpf_cnpj, senha@senha";
                    cmd.Parameters.AddWithValue("@nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@email", obj.Email);
                    cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", obj.CPF_CNPJ);
                    cmd.Parameters.AddWithValue("@senha", obj.Senha);


                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }

        }

        public bool UpDateDadosAdmin(tb_login obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_login set tipo=@tipo, ativo=@ativo";

                    cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@ativo", obj.Ativo);

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }

        }

        public bool ExcluirDados(int Codigo)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "delete from tb_login  where codigologin=@codigologin";
                    cmd.Parameters.AddWithValue("@codigologin", Codigo);

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }
        }
        public bool Validalogin(tb_login obj)

        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where nome=@nome";
                cmd.Parameters.AddWithValue("@nome", obj.Nome);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        /*public async Task<bool> ValidarNomeLoginAsync(tb_login obj, IHttpContextAccessor hcont)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where email=@email and senha=@senha";

                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@tipo", obj.Tipo);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    Dr.Read();
                    var claims1 = new[]
                                               {
                                new Claim("Nome",Dr["Nome"].ToString()),
                                new Claim("Email",Dr["Email"].ToString()),
                                new Claim("Tipo",Dr["Tipo"].ToString()),
                                new Claim(ClaimTypes.Role, "Logado"),
                                new Claim(ClaimTypes.Role, Dr["Tipo"].ToString()),
                    }.ToList();


                    var identity1 = new ClaimsIdentity(claims1, CookieAuthenticationDefaults.AuthenticationScheme);
                    await hcont.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity1));
                }


                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }*/


        public List<tb_login> GetAll()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_login>();

                while (Dr.Read())
                {
                    var item = new tb_login
                    {
                        CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                        Nome = Dr["Nome"].ToString(),
                        Email = Dr["Email"].ToString(),
                        Telefone = Dr["Telefone"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<tb_login> GetAllFuncionario()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where tipo='F' order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_login>();

                while (Dr.Read())
                {
                    var item = new tb_login
                    {
                        CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                        Nome = Dr["Nome"].ToString(),
                        Email = Dr["Email"].ToString(),
                        Telefone = Dr["Telefone"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<tb_login> GetAllCliente()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where tipo='C' order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_login>();

                while (Dr.Read())
                {
                    var item = new tb_login
                    {
                        CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                        Nome = Dr["Nome"].ToString(),
                        Email = Dr["Email"].ToString(),
                        Telefone = Dr["Telefone"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }
    }


}

