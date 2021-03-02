using ECCE.Data;
using ECCE.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Controllers
{
    public class CategoriaController : Controller
    {


        public IActionResult Index()
        {
            CategoriaDB Cat = new CategoriaDB();
            var MLista = Cat.GetAllCategoria();
            return View(MLista);
        }
        public IActionResult CadastroCategoria()
        {

            ViewData["Valida"] = "";
            return View();
        }

        public IActionResult Excluir(int codigocategoria)
        {
            CategoriaDB Cat = new CategoriaDB();
            Cat.ExcluirDados(codigocategoria);
            return RedirectToAction("index", "categoria");
        }

        public IActionResult Editar(int CodigoCategoria, string Descricao)
        {
            var model = new tb_categoria();
            model.CodigoCategoria = CodigoCategoria;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroCategoria", model);
        }
        public IActionResult Salvar(tb_categoria obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("Cadastrocategoria");
            }

            CategoriaDB Cat = new CategoriaDB();

            if (obj.CodigoCategoria == 0)
            {

                if (Cat.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Categoria inserida com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Categoria!</div>";
                }
            }
            else
            {
                if (Cat.UpdateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Categoria atualizada com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Categoria!</div>";
                }

            }
                return View("cadastrocategoria");
        }

        public string Validar(tb_categoria obj)
        {

            CategoriaDB Cat = new CategoriaDB();

            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome da categoria</div>";
            }

            if (Cat.ValidarNome(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Categoria já cadastradoa!</div>";
            }

            return "";
        }
    }
}
