using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Campeonato
    {
        private int campeonatoId;
        private string nome;
        private int duracao;

        public int CampeonatoId { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }


        //Relacionamentos
        public List<Time> Times { get; set; }
    }
}