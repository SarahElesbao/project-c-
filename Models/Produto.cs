using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVCSQL.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Código")]
        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        public string Nome { get; set; }

        [Column("Fabricante")]
        [Display(Name = "Fabricante")]
        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        public string Fabricante{ get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        public string Categoria{ get; set; }

        [Column("Preço")]
        [Display(Name = "Preço")]
        [Required(ErrorMessage="O nome do usuário é obrigatório")]
        public float preco{ get; set; }
       
    }
}
