using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Produto
    {
        private string nome;
        private decimal preco;
        private string descricao;
        private DateTime dataFabricacao;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }
    }
}