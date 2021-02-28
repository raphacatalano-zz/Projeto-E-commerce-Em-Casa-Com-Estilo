using ECCE.Data;
using ECCE.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult CadastroProduto()
        {
            ProdutoDB Cat = new ProdutoDB();
            ProdutoDB Cor = new ProdutoDB();
            ProdutoDB Foto = new ProdutoDB();
            ProdutoDB Gen = new ProdutoDB();
            ProdutoDB Tam = new ProdutoDB();


            ViewData["LTCategorias"] = Cat.GetCategoria();
            ViewData["LTCor"] = Cor.GetCor();
            ViewData["LTFoto"] = Foto.GetFoto();
            ViewData["LTGenero"] = Gen.GetGenero();
            ViewData["LTTam"] = Tam.GetTamanho();

            ViewData["Valida"] = "";
            return View();
        }


        public IActionResult Editar(int CodigoProduto, string Nome, string Descricao, double Valor, DateTime DataRegistro, double Peso, 
                                    string Categoria, string Cor, string Foto, string Genero, string Tamanho)
        {
            var model = new ProdutoModelVW();
            model.tb_produto.CodigoProduto = CodigoProduto;
            model.tb_produto.Nome = Nome;
            model.tb_produto.Descricao = Descricao;
            model.tb_produto.Valor = Valor;
            model.tb_produto.Peso = Peso;
            model.Categoria = Categoria;
            model.Cor = Cor;
            model.Foto = Foto;
            model.Genero = Genero;
            model.Tamanho = Tamanho;
            ViewData["Valida"] = "";
            return View("index", model);
        }

        public IActionResult Salvar(ProdutoModel obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("index");
            }

            ProdutoDB Prod = new ProdutoDB();

            if (obj.tb_produto.CodigoProduto == 0)
            {

                if (Prod.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cliente inserido(a) com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Cliente!</div>";
                }
            }


            return View("index");
        }

        public string Validar(ProdutoModel obj)
        {

            ProdutoDB Func = new ProdutoDB();

            if (String.IsNullOrEmpty(obj.tb_produto.Nome))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome do produto</div>";
            }

            if (Func.ValidarNome(obj.tb_produto))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Produto já cadastrado(a)!</div>";
            }

            return "";
        }
    }
}
