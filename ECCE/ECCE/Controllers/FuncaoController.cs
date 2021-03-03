using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;

namespace ECCE.Controllers
{
    public class FuncaoController : Controller
    {
        public IActionResult Index()
        {
            FuncionarioFuncaoDB Funcao = new FuncionarioFuncaoDB();
            var MLista = Funcao.GetAllFuncao();
            return View(MLista);
        }

        public IActionResult CadastroFuncao()
        {
            ViewData["Valida"] = "";
            return View();
        }

        public IActionResult Excluir(int codigo)
        {
            FuncionarioFuncaoDB Funcao = new FuncionarioFuncaoDB();
            Funcao.ExcluirDados(codigo);
            return RedirectToAction("index", "funcao");
        }

        public IActionResult Editar(int CodigoFuncao, string Descricao)
        {
            var model = new tb_funcionario_funcao();
            model.CodigoFuncao = CodigoFuncao;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroFuncao", model);
        }

        public IActionResult Salvar(tb_funcionario_funcao obj)
        {
            string smgvalida = ValidarFuncao(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroFuncao");
            }

            FuncionarioFuncaoDB Cor = new FuncionarioFuncaoDB();

            if(obj.CodigoFuncao == 0)
            {
                if (Cor.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Funçao inserida com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Função!</div>";
                }
            }
            else
            {
                if (Cor.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Função atualizada com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Função!</div>";
                }
            }
            return View("cadastrofuncao");
        }

        public string ValidarFuncao(tb_funcionario_funcao obj)
        {
            FuncionarioFuncaoDB Funcao = new FuncionarioFuncaoDB();

            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome da função</div>";
            }
            if (Funcao.ValidaFuncao(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Função já existente!</div>";
            }
            return "";
        }




    }
}
