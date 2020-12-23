using System;
using System.ComponentModel.DataAnnotations;

namespace Api.ControleFinanceiro.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo e Obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter no maximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter no minimo 3 Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        public int TipoLancamentoId { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        public int ContaId { get; set; }

        public DateTime DataCriacao = DateTime.Now;


    }
}