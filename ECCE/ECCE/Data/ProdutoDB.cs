using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ECCE.Classes;
using ECCE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_produto (Nome, Descricao, valor, dataregistro, peso)values(@nome, @descricao, @valor, @dataregistro, @peso)";
                cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.tb_produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", obj.tb_produto.Valor);
                cmd.Parameters.AddWithValue("@dataregistro", obj.tb_produto.DataRegistro);
                cmd.Parameters.AddWithValue("@peso", obj.tb_produto.Peso);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                AddCategoria(obj);
                AddCor(obj);

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
            catch (Exception)
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

        public bool AddTamanho(ProdutoModel obj)
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
                int CodigoTamanho = 0;

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_produto_tamanho where CodigoProduto=" + CodigoProduto;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_produto_genero)
                {
                    CodigoTamanho++;
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_produto_tamanho (CodigoTamanho,CodigoProduto)";
                    sSQL += "values(@CodigoTamanho,@CodigoProduto)";
                    cmd.Parameters.AddWithValue("@CodigoTamanho", CodigoTamanho);
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

        public List<SelectListItem> GetCategoria()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_categoria";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoCategoria"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetCor()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_cor";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoCor"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetFoto()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto_foto";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoFoto"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetGenero()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_genero";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoGenero"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        public List<SelectListItem> GetTamanho()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_tamanho";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoTamanho"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public bool ValidarNome(tb_produto obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where nome=@nome";
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

        public List<tb_produto> GetAllProduto()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_produto>();

                while (Dr.Read())
                {
                    var item = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDouble(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
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
