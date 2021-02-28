using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ECCE.Classes;
using ECCE.Models;

namespace ECCE.Data
{
    public class ProdutoDB
    {

        public bool InserirDados(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "insert into tb_funcionario(Nome)values(@nome)";
                cmd.Parameters.AddWithValue("@nome", obj.tb_funcionario.Nome);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                AddBNF(obj);
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool AddCategoria(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                cmd.Connection = cn;

                var CodigoProduto = obj.tb_produto.CodigoProduto;
                if (obj.tb_produto.CodigoProduto == 0)
                {
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                    cmd.CommandText = sSQL;
                    var Dr = cmd.ExecuteReader();
                    Dr.Read();
                    CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"].ToString());
                    Dr.Dispose();
                }
                int CodigoCategoria = 0;

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_produto_categoria where CodigoProduto=" + CodigoProduto;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_produto_categoria)
                {
                    CodigoCategoria++;
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_produto_categoria (CodigoCategoria,CodigoProduto)";
                    sSQL += "values(@CodigoCategoria,@CodigoProduto)";
                    cmd.Parameters.AddWithValue("@CodigoCategoria", CodigoCategoria);
                    cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool AddCor(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                cmd.Connection = cn;

                var CodigoProduto = obj.tb_produto.CodigoProduto;
                if (obj.tb_produto.CodigoProduto == 0)
                {
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                    cmd.CommandText = sSQL;
                    var Dr = cmd.ExecuteReader();
                    Dr.Read();
                    CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"].ToString());
                    Dr.Dispose();
                }
                int CodigoCor = 0;

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_produto_cor where CodigoProduto=" + CodigoProduto;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_produto_cor)
                {
                    CodigoCor++;
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_produto_cor (CodigoCor,CodigoProduto)";
                    sSQL += "values(@CodigoCor,@CodigoProduto)";
                    cmd.Parameters.AddWithValue("@CodigoCor", CodigoCor);
                    cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddFoto(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                cmd.Connection = cn;

                var CodigoProduto = obj.tb_produto.CodigoProduto;
                if (obj.tb_produto.CodigoProduto == 0)
                {
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                    cmd.CommandText = sSQL;
                    var Dr = cmd.ExecuteReader();
                    Dr.Read();
                    CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"].ToString());
                    Dr.Dispose();
                }
                int CodigoFoto = 0;

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_produto_foto where CodigoProduto=" + CodigoProduto;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_produto_foto)
                {
                    CodigoFoto++;
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_produto_foto (CodigoFoto,CodigoProduto, Descricao, Caminho)";
                    sSQL += "values(@CodigoCor,@CodigoProduto, @Descricao,@Caminho)";
                    cmd.Parameters.AddWithValue("@CodigoFoto", CodigoFoto);
                    cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                    cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
                    cmd.Parameters.AddWithValue("@Caminho", item.Caminho);

                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddGenero(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                cmd.Connection = cn;

                var CodigoProduto = obj.tb_produto.CodigoProduto;
                if (obj.tb_produto.CodigoProduto == 0)
                {
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                    cmd.CommandText = sSQL;
                    var Dr = cmd.ExecuteReader();
                    Dr.Read();
                    CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"].ToString());
                    Dr.Dispose();
                }
                int CodigoGenero = 0;

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_produto_genero where CodigoProduto=" + CodigoProduto;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_produto_genero)
                {
                    CodigoGenero++;
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_produto_genero (CodigoGenero,CodigoProduto)";
                    sSQL += "values(@CodigoGenero,@CodigoProduto)";
                    cmd.Parameters.AddWithValue("@CodigoGenero", CodigoGenero);
                    cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool UpdateDados(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "update tb_funcionario set Nome=@nome where CodigoFuncionario=@CodigoFuncionario";
                cmd.Parameters.AddWithValue("@nome", obj.tb_funcionario.Nome);
                cmd.Parameters.AddWithValue("@CodigoFuncionario", obj.tb_funcionario.CodigoFuncionario);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                AddBNF(obj);
                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool ExcluirDados(int Codigo)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "delete from tb_funcionario where CodigoFuncionario=@CodigoFuncionario;";
                sSQL += "delete from tb_funcionario_beneficios where CodigoFuncionario=@CodigoFuncionario;";
                cmd.Parameters.AddWithValue("@CodigoFuncionario", Codigo);

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

        public bool ValidarNome(tb_produto obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "select * from tb_funcionario where nome=@nome";
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


        public List<tb_produto> GetAll()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "select * from tb_funcionario order by nome";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_funcionario>();

                while (Dr.Read())
                {
                    var item = new tb_funcionario
                    {
                        CodigoFuncionario = Convert.ToInt32(Dr["CodigoFuncionario"]),
                        Nome = Dr["Nome"].ToString()
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


        public ProdutoModel GetFuncionario(int CodigoFuncionario)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.GET_StringConexao());
                cn.Open();

                sSQL = "select * from tb_funcionario where CodigoFuncionario=@CodigoFuncionario";
                cmd.Parameters.AddWithValue("@CodigoFuncionario", CodigoFuncionario);
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrFun = cmd.ExecuteReader();
                DrFun.Read();


                var tbFun = new tb_funcionario()
                {
                    CodigoFuncionario = Convert.ToInt32(DrFun["CodigoFuncionario"]),
                    Nome = DrFun["Nome"].ToString()
                };

                DrFun.Dispose();

                //Carrega BNF                
                sSQL = "select * from tb_funcionario_beneficios where CodigoFuncionario=@CodigoFuncionario";
                cmd.CommandText = sSQL;
                var DrBNFS = cmd.ExecuteReader();

                var tb_bnf = new List<tb_funcionario_beneficios>();

                while (DrBNFS.Read())
                {
                    tb_bnf.Add(new tb_funcionario_beneficios()
                    {
                        CodigoBeneficio = Convert.ToInt32(DrBNFS["CodigoBeneficio"]),
                        CodigoFuncionario = Convert.ToInt32(DrBNFS["CodigoFuncionario"]),
                        Descricao = DrBNFS["Descricao"].ToString(),
                        Valor = Convert.ToDouble(DrBNFS["Valor"])
                    });
                }

                var model = new FuncionarioModel();
                model.tb_funcionario = tbFun;
                model.tb_funcionario_beneficios = tb_bnf;

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

    }
}
