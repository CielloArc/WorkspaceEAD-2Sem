using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Time
    {
        private int timeId;
        private string nome;
        private DateTime dataFundacao;

        
        public int TimeId
        {
            get { return timeId; }
            set { timeId = value; }
        }
        [Required]
        [MinLength(5)]
        public string Nome
        {
           get { return nome; }
           set { nome = value; }
        }
        [Display(Name ="Data de Fundacao")]
        public DateTime DataFundacao
        {
            get { return dataFundacao; }
            set { dataFundacao = value; }
        }


        //Relacionamento 1:1
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }


        //Relacionamento 1:N
        public List<Jogador> Jogadores { get; set; }

        //Relacionamento 1:BANANA
        public List<Campeonato> Campeonatos { get; set; }


    }
}