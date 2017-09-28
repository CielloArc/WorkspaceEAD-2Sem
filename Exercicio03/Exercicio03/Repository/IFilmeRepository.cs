using Exercicio03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Repository
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme filme);
        List<Filme> Listar();
        void Alterar(Filme filme);
        void Remover(int codigo);
    }
}
