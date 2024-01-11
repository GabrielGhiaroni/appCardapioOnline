using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appCardapioOnline {

    [Table("Lanches")]
    public class Lanche {

        [Key]
        public int LancheId {get; set;}

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name="Nome do Lanche")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name="Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição deve ter, no mínimo, {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição não pode exceder {1} caracteres.")]
        public string DescricaoCurta {get; set;}


        public string DescricaoDetalhada {get; set;}
        public decimal Preco {get; set;}
        public string ImagemURL {get; set;}
        public string ImagemThumbnailURL {get; set;}
        public bool IsLanchePreferido {get; set;}
        public bool EmEstoque {get; set;}
        public int CategoriaId {get; set;}
        public virtual Categoria Categoria {get; set;}
    }
}