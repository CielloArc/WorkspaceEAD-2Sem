using Fiap.Exemplo04.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.Web.MVC.Repositories
{
    public interface ITimeRepository
    {
        void Cadastrar(Time time);
        List<Time> Listar();
        void Atualizar(Time time);
        void Remover(int codigo);
        List<Time> BuscarPor(Expression<Func<Time,bool>>filtro);

    }
}
