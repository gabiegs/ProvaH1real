using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Controllers
{
    public class Jogador
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatorio")]
        [Range(11, 11, ErrorMessage = "O CPF deve ter 11 digitos")]
        public string CPF { get; set; }
        [StringLength(500, ErrorMessage = "Descrição deve ter no máximo 500 caracteres")]
        [Required(ErrorMessage = "Descrição é obrigatoria")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Posição é obrigatoria")]
        public string Posicao { get; set; }
    }
}