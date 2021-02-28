using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class CaracteristicaModel
    {
        public tb_categoria tb_categoria { get; set; }
        public tb_cor tb_cor { get; set; }
        public tb_genero tb_genero { get; set; }
        public tb_tamanho tb_tamanho { get; set; }
    }

    public class tb_categoria
    {
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; }
    }

    public class tb_cor
    {
        public int CodigoCor { get; set; }
        public string Descricao { get; set; }
    }

    public class tb_genero
    {
        public int CodigoGenero { get; set; }
        public string Descricao { get; set; }
    }

    public class tb_tamanho
    {
        public int CodigoTmanho { get; set; }
        public string Descricao { get; set; }
    }
}

