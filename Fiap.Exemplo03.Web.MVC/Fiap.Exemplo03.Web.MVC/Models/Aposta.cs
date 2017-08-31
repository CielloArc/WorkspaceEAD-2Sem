using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.Web.MVC.Models
{
    public class Aposta
    {
        public int Id { get; set; }

        [Required]
        public decimal Valor { get; set; }
        
        public bool Dobradinha { get; set; }

        [Display(Name = "Data da Aposta")]
        public DateTime DataAposta { get; set; }
    }
}