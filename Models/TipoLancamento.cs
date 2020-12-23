using System.ComponentModel.DataAnnotations;

namespace Api.ControleFinanceiro.Models
{
    public class TipoLancamento
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo e Obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter no maximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter no minimo 3 Caracteres")]
        public string Nome { get; set; }
    }
}