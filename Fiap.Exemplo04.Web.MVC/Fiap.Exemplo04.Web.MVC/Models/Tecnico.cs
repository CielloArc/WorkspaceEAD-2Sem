using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Tecnico
    {

        private int tecnicoId;
        private string nome;
        private decimal salario;

        [Key]        
        public int TecnicoID { get { return tecnicoId; } set {tecnicoId = value; } }
        [Required]
        [MinLength(4)]
        [Display(Name = "Nome do Tecnico")]
        public string Nome { get { return nome; } set { nome = value; } }
        [Required]        
        public decimal Salario { get {return salario; } set { salario = value; } }
    }
}