using System.ComponentModel.DataAnnotations;

namespace Api.ControleFinanceiro.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo e Obrigatorio")]
        public int UsuarioId { get; set; }




    }
}