using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Models
{
    public class Peneira
    {
        [Range(11, 11, ErrorMessage = "CPF deve ter 11 digitos")]
        [Required(ErrorMessage = "CPF obrigatorio")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Resultado não pode ser nulo")]
        public bool Aprovado { get; set; }
    }
}