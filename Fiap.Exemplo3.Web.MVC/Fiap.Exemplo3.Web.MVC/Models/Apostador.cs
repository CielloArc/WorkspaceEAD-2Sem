using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo3.Web.MVC.Models
{
    public class Apostador
    {
        private int id;
        private string nome;
        private string email;
        private DateTime dataNascimento;
        private decimal saldo;

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        [Required]
        [MinLength(15)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [Required]
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        [Required]
        [Column("SaldoTotal")]
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}