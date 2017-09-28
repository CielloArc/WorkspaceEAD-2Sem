using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio03.Models
{
    public class Produtora
    {

        [Key]
        public int ProdutoraId { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2, ErrorMessage ="Nome não pode ter menos de 2 ou mais que 100 letras")]
        public string Nome { get; set; }
    }
}