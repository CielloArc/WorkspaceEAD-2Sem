using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar a classe PessoaJuridica
            var pj = new PessoaJuridica("Fiap");

            var pf = new PessoaFisica("Rita")
            {                
                Cpf = "352.233.566-99"
            };

            //Colocar valores nos atributos
            //pj.Nome = "Fiap";
            pj.Cnpj = "123.654.546-0001/56";
            //Exibir o Nome 
            Console.WriteLine(pj.Nome);

            //Criar uma lista de pessoa Fisica
            IList<PessoaFisica> lista = new List<PessoaFisica>();
            lista.Add(new PessoaFisica("Juliana"));
            lista.Add(new PessoaFisica("Attos"));
            lista.Add(new PessoaFisica("Aline"));

            //Imprimir os valores
            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadLine(); //Parar a execução
        }
    }
}
