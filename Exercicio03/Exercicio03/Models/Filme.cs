using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio03.Models
{
    public class Filme
    {
        [Key]
        public int FilmeId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage ="Titulo deve possuir pelo menos duas letras")]
        public string Titulo { get; set; }
        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="Genero não pode ser menor que 4 ou maior que 8 letras")]
        public string Genero { get; set; }
        [Required]
        [Range(60, 320, ErrorMessage = "Duraçao não pode ser menor que 60 ou maior que 320 minutos")]
        public int Duracao { get; set; }

        [Required]
        [Display(Name = "Data de Lancamento")]
        [DataType(DataType.DateTime, ErrorMessage ="Insira uma data valida")]
        public DateTime DataLancamento { get; set; }


        //RELACIONAMENTOS
        public Produtora Produtora { get; set; }
        public int ProdutoraId { get; set; }

    }
}