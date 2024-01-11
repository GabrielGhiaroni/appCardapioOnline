using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appCardapioOnline {

    [Table("Lanches")]
    public class Lanche {

        [Key]
        public int LancheId {get; set;}

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho mínimo de {1} e, no máximo, de {2}.")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição deve ter, no mínimo, {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição não pode exceder {1} caracteres.")]
        public string DescricaoCurta {get; set;}

        [Required(ErrorMessage = "A descrição detalhada deve ser informada.")]
        [Display(Name = "Descrição detalhada")]
        [MinLength(20, ErrorMessage = "A descrição deve ter, no mínimo, {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição não pode exceder {1} caracteres.")]
        public string DescricaoDetalhada {get; set;}

        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99.")]
        public decimal Preco {get; set;}

        [Required(ErrorMessage = "Informe a URL da imagem do lanche.")]
        [Display(Name = "URL da imagem do lanche")]
        [StringLength(200, ErrorMessage = "A URL deve ter, no máximo, {1} caracteres.")]
        public string ImagemURL {get; set;}

        [Display(Name = "Caminho imagem miniatura")]
        [StringLength(200, ErrorMessage = "A URL deve ter, no máximo, {1} caracteres.")]
        public string ImagemThumbnailURL {get; set;}

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido {get; set;}

        [Display(Name = "Em estoque?")]
        public bool EmEstoque {get; set;}
        public int CategoriaId {get; set;}
        public virtual Categoria Categoria {get; set;}
    }
}