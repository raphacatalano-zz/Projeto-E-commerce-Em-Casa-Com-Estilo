using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;

namespace ECCE.Controllers
{
    public class GeneroController : Controller
    {
        public IActionResult Index()
        {
            GeneroDB Genero = new GeneroDB();
            var MLista = Genero.GetAllGenero();
            return View(MLista);
        }

        public IActionResult CadastroGenero()
        {
            ViewData["Valida"] = "";
            return View();
        }

        public IActionResult Excluir(int CodigoGenero)
        {
            GeneroDB Cor = new GeneroDB();
            Cor.ExcluirDados(CodigoGenero);
            return RedirectToAction("index", "genero");
        }

        public IActionResult Editar(int CodigoGenero, string Descricao)
        {
            var model = new tb_genero();
            model.CodigoGenero = CodigoGenero;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroGenero", model);
        }

        public IActionResult Salvar(tb_genero obj)
        {
            string smgvalida = Validar(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroGenero");
            }

            GeneroDB Genero = new GeneroDB();

            if(obj.CodigoGenero == 0)
            {
                if (Genero.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Genero inserido com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Genero!</div>";
                }
            }
            else
            {
                if (Genero.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Genero atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Genero!</div>";
                }
            }
            return View("cadastrogenero");
        }

        public string Validar(tb_genero obj)
        {
            GeneroDB Genero = new GeneroDB();
            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o Genero</div>";
            }
            if (Genero.ValidaGenero(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Cor já existente!</div>";
            }
            return "";
        }




    }
}
