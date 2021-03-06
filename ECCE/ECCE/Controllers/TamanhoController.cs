using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;

namespace ECCE.Controllers
{
    public class TamanhoController : Controller
    {
        public IActionResult Index()
        {
            TamanhoDB Cor = new TamanhoDB();
            var MLista = Cor.GetAllTamanho();
            return View(MLista);
        }

        public IActionResult CadastroTamanho()
        {
            ViewData["Valida"] = "";
            return View();
        }

        public IActionResult Excluir(int CodigoTamanho)
        {
            TamanhoDB Cor = new TamanhoDB();
            Cor.ExcluirDados(CodigoTamanho);
            return RedirectToAction("index", "Tamanho");
        }

        public IActionResult Editar(int CodigoTamanho, string Descricao)
        {
            var model = new tb_tamanho();
            model.CodigoTamanho = CodigoTamanho;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroTamanho", model);
        }

        public IActionResult Salvar(tb_tamanho obj)
        {
            string smgvalida = Validar(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroTamanho");
            }

            TamanhoDB Tamanho = new TamanhoDB();

            if(obj.CodigoTamanho == 0)
            {
                if (Tamanho.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Tamanho inserido com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Tamanho!</div>";
                }
            }
            else
            {
                if (Tamanho.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Tamanho atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Tamanho!</div>";
                }
            }
            return View("cadastrotamanho");
        }

        public string Validar(tb_tamanho obj)
        {
            TamanhoDB Tamanho = new TamanhoDB();
            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o Tamanho</div>";
            }
            if (Tamanho.ValidaTamanho(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Tamanho já existente!</div>";
            }
            return "";
        }




    }
}
