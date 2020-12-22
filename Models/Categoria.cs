using System;
using System.ComponentModel.DataAnnotations;

namespace Api.ControleFinanceiro.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int UsuarioCadastro { get; set; }

        public DateTime DataCadastro = DateTime.Now;

    }
}