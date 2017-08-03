using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class PessoaJuridica : Pessoa, ILoja
    {
        //Propriedade
        public string Cnpj { get; set; }

        //Construtor
        public PessoaJuridica(string nome):base(nome)
        {

        }

        public override void Comprar()
        {
            Console.WriteLine("PJ Comprando");
        }

        //Sobrescrever o método Vender
        public override void Vender()
        {
            Console.WriteLine("PJ Vendendo");
        }

        public void Devolver(string produto)
        {
            Console.WriteLine("Devolvendo produto: " + produto);
        }
    }
}
