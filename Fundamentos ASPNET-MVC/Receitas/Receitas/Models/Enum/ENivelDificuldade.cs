using System.ComponentModel.DataAnnotations;

namespace Receitas.Models.Enum
{
    public enum ENivelDificuldade
    {
        [Display(Name = "Fácil")]
        Facil = 0,

        [Display(Name = "Intermediário")]
        Intermediario = 1,

        [Display(Name = "Complexo")]
        Complexo = 2,
    }
}
