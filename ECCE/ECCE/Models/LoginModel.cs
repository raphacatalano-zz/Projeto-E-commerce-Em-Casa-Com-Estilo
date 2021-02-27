using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome", Prompt ="")]
        public string Nome { get; set; }

        public string Email { get; set; }

        [Display(Name = "Senha", Prompt = "")]
        public string Senha { get; set; }
    }
}
