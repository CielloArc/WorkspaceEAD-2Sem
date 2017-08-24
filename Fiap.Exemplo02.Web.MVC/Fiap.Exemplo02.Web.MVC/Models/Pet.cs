using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Pet
    {
        private int codigo;
        private string nome;
        private bool castrado;
        private string descricao;
        private DateTime dataNascimento;
        private string especie;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public bool Castrado
        {
            get { return castrado; }
            set { castrado = value; }
        }
        [Display(Name = "Descrição")]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        
        [Display(Name ="Data Nascimento")]        
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        [Display(Name = "Espécie")]
        public String Especie
        {
            get { return especie; }
            set { especie = value; }
        }
    }
}