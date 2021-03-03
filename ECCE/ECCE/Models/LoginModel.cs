using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class LoginModel
    {
        tb_login tb_Login { get; set; }
        List<tb_funcionario_funcao> tb_funcionario_funcao { get; set; }
    }
    public class tb_login
    {
        public int CodigoLogin { get; set; }

        [Display(Name = "Nome", Prompt = "")]
        public string Nome { get; set; }

        [Display(Name = "Email", Prompt = "")]
        public string Email { get; set; }

        [Display(Name = "Telefone", Prompt = "")]
        public string Telefone { get; set; }

        [Display(Name = "CPF/CNPJ", Prompt = "")]
        public string CPF_CNPJ { get; set; }

        [Display(Name = "CodigoFuncao", Prompt = "")]
        public string CodigoFuncao { get; set; }

        [Display(Name = "Senha", Prompt = "")]
        public string Senha { get; set; }

        [Display(Name = "Tipo", Prompt = "")]
        public string Tipo { get; set; }

        [Display(Name = "Data Cadastro", Prompt = "")]
        public string DataCadastro { get; set; }

        [Display(Name = "Ativo", Prompt = "")]
        public string Ativo { get; set; }
    }

    public class tb_funcionario_funcao
    {
        public int CodigoFuncao { get; set; }
        public string Descricao { get; set; }
    }

}
