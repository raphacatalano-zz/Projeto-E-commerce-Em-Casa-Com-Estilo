using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;

namespace ECCE.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            LoginDB Usuario = new LoginDB();
            var MLista = Usuario.GetAll();
            return View(MLista);
        }

        public IActionResult Cliente()
        {
            LoginDB Cliente = new LoginDB();
            var MLista = Cliente.GetAllCliente();
            return View(MLista);
        }

        public IActionResult Funcionario()
        {
            LoginDB Funcionario = new LoginDB();
            var MLista = Funcionario.GetAllFuncionario();
            return View(MLista);
        }

        public IActionResult EditarCliente(int CodigoLogin, string Nome, string Email, string Telefone, string Cpf, string Senha, string Tipo, string Ativo)
        {
            var model = new tb_login();
            model.CodigoLogin = CodigoLogin;
            model.Nome = Nome;
            model.Email = Email;
            model.Telefone = Telefone;
            model.CPF_CNPJ = Cpf;
            model.Senha = Senha;
            model.Tipo = Tipo;
            model.Ativo = Ativo;
            ViewData["Valida"] = "";
            return View("CadastroCliente", model);
        }

        public IActionResult EditarAdmin(int CodigoLogin, string Tipo, string Ativo)
        {
            var model = new tb_login();
            model.CodigoLogin = CodigoLogin;
            model.Tipo = Tipo;
            model.Ativo = Ativo;
          
            ViewData["Valida"] = "";
            return View("CadastroFuncionario", model);
        }

        public IActionResult SalvarCliente(tb_login obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroCliente");
            }

            LoginDB Usuario = new LoginDB();

            if (Usuario.UpDateDadosUsuario(obj))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cliente atualizado com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Cliente!</div>";
            }

            return View("cadastroCliente");
        }

        public IActionResult SalvarFuncionario(tb_login obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroFuncionario");
            }
            LoginDB Usuario = new LoginDB();

            if (Usuario.UpDateDadosAdmin(obj))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Funcionário atualizado com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar funcionário!</div>";
            }

            return View("cadastroFuncionario");
        }

        public string Validar(tb_login obj)
        {
            LoginDB Usuario = new LoginDB();
            if (String.IsNullOrEmpty(obj.Tipo))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o tipo</div>";
            }
            if (Usuario.Validalogin(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Nome já existente!</div>";
            }
            return "";
        }




    }
}
