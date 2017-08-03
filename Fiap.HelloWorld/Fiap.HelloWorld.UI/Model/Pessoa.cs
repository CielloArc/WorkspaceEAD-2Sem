using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    abstract class Pessoa
    {
        //Field
        private string _nome;

        //Gets e Sets
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        //Construtor
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        //Método
        public abstract void Comprar();

        //virtual -> permite a sobrescrita do método
        public virtual void Vender()
        {
            Console.WriteLine("Pessoa vendendo");
        }

    }
}
