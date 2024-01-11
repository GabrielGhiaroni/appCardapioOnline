using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appCardapioOnline {

    [Table("Categorias")]
    public class Categoria {

        [Key]
        public int CategoriaId {get; set;}

        [Required(ErrorMessage = "O nome da Categoria é obrigatório.")]
        [StringLength(100, ErrorMessage = "Tamanho máximo permitido de ${1} caracteres.")]
        [Display(Name = "Nome")]
        public string CategoriaNome {get; set;}

        [Required(ErrorMessage = "A descrição da Categoria é obrigatória.")]
        [StringLength(200, ErrorMessage = "Tamanho máximo permitido de ${1} caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao {get; set;}

        public List<Lanche> Lanches {get; set;}
    }
}