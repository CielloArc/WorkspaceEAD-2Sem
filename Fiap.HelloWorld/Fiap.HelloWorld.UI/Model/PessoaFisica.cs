using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class PessoaFisica : Pessoa
    {
        //Propriedade
        public string Cpf { get; set; }

        public Sexo Sexo { get; set; }

        //Construtor
        public PessoaFisica(string nome):base(nome)
        {

        }

        public override void Comprar()
        {
            Console.WriteLine("PF Comprando");
        }
    }
}
