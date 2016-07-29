using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
 public class Produto
    {

     [HiddenInput(DisplayValue = true)]
     public int ProdutoId { get; set; }
     [Required(ErrorMessage="Digite o nome do Produto")]
     public string Nome { get; set; }
     [DataType(DataType.MultilineText)]
     [Required(ErrorMessage="Digite a descrição do Produto")]
     public string Descricao { get; set; }
     [Required(ErrorMessage="Digite o valor")]
     [Range(0.01,double.MaxValue,ErrorMessage="Valor inválido")]
     public  decimal Preco { get; set; }
     [Required(ErrorMessage="Digite a categoria")]
     public string Categoria  { get; set; }


        

    }
}
