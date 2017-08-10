using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio02.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DataAbertura = DateTime.Now,
                Saldo = 100,
                Tipo = Model.TipoConta.Comum
            };
            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 123,
                Numero = 222,
                DataAbertura = DateTime.Now,
                Saldo = 500,
                Taxa = 1
            };

            //Chamar os métodos
            cc.Depositar(100);
            cc.Retirar(50);
            Console.Write(cc.Saldo);
            Console.Write(cp.CalculaRetornoInvestimento());
            Console.ReadLine(); //para a tela..
        }
    }
}
