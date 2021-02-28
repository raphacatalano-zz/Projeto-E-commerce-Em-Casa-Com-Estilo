using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class ProdutoModel
    {
        public tb_produto tb_produto { get; set; }
        public List<tb_produto_categoria> tb_produto_categoria { get; set; }
        public List<tb_produto_cor> tb_produto_cor { get; set; }
        public List<tb_produto_foto> tb_produto_foto { get; set; }
        public List<tb_produto_genero> tb_produto_genero { get; set; }
        public List<tb_produto_tamanho> tb_produto_tamanho { get; set; }
        public string JsonLTBNF { get; set; }

    }

    public class tb_produto
    {
        [Key]
        public int CodigoProduto { get; set; }  // ADICIONAR O ATRIBUTO [KEY] SE O CAMPO FOR AUTONUMERIC,ASSIM ELE NÃO ENTRA NO INSERT.

        [Display(Name = "Nome", Prompt = "")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Prompt = "")]
        public double Descricao { get; set; }

        [Display(Name = "Valor", Prompt = "")]
        public double Valor { get; set; }

        [Display(Name = "Data Registro", Prompt = "")]
        public int DataRegistro { get; set; }

        [Display(Name = "Peso", Prompt = "")]
        public int Peso { get; set; }
    }

    public class tb_produto_categoria
    {
        public int CodigoCategoria { get; set; }
        public int CodigoProduto { get; set; }
    }
    public class tb_produto_cor
    {
        public int CodigoCor { get; set; }
        public int CodigoProduto { get; set; }
    }

    public class tb_produto_foto
    {
        public int CodigoFoto { get; set; }
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public string Caminho { get; set; }
    }

    public class tb_produto_genero
    {
        public int CodigoGenero { get; set; }
        public int CodigoProduto { get; set; }
    }
    public class tb_produto_tamanho
    {
        public int CodigoTamanho { get; set; }
        public int CodigoProduto { get; set; }
    }

}
