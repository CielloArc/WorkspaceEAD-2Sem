using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Revisao.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        List<Cliente> Listar();
        void Atualizar(Cliente cliente);
        void Remover(int codigo);
    }
}
