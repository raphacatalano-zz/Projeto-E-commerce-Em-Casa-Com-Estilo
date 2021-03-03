using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class EnderecoModel
    {
        tb_endereco tb_endereco { get; set; }
    }
    
    public class tb_endereco
    {
        public int CodigoEnderoco { get; set; }
        public int CodigoLogin { get; set; }
        public string Descricao { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }

}
