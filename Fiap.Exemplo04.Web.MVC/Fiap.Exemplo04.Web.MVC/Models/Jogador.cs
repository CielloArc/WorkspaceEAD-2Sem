using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Jogador
    {
        private int jogadorId;
        private string nome;
        private int numero;

        [Key]
        public int JogadorId { get { return jogadorId; } set { jogadorId = value; } }
        [Required]
        public string Nome { get { return nome; } set { nome = value; } }
        [Required]
        public int Numero { get { return numero; } set { numero = value; } }


        //Relacionamento
        public Time Time { get; set; }
        public int TimeId { get; set; }

    }
}