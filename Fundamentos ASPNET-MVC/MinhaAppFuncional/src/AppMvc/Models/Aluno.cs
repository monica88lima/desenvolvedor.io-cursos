using Microsoft.AspNetCore.Http.Connections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace AppMvc.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength =2, ErrorMessage = "O campo {0} precisa ter entre {1} e {2} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} está em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage ="O campo {0} precisa ter no máximo {1} carecteres")]
        [EmailAddress(ErrorMessage ="O campo {0} está em formato inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage ="Os e-mails informados não são idênticos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1,5,ErrorMessage ="O Campo {0} deve estar entre {1} e {2}")]
        public int Avaliacao { get; set; }
     
        public bool Ativo {  get; set; }
    }
}
