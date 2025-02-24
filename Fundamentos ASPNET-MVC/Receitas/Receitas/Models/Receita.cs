using System.ComponentModel.DataAnnotations;

namespace Receitas.Models
{
    public class Receita
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório {0}")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo deve ter entre {2} e {1} caracteres" )]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório {0}")]
        [MinLength(5, ErrorMessage = "Campo deve conter instrução de preparo com no mínimo {0} caracteres")]
        public string? Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obrigatório {0}")]
        [MinLength(5, ErrorMessage = "Campo deve conter instrução de preparo com no mínimo {0} caracteres")]
        [Display(Name = "Modo de Preparo")]
        public string? ModoPreparo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da Publicação")]
        public DateTime DataPublicacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O tempo médio de preparo é obrigatório.")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tempo médio de preparo")]
        public TimeSpan TempoPreparo { get; set; }

      
        public bool Ativo {  get; set; } = true;

    }
}
