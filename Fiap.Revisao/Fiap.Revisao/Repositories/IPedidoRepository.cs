using Fiap.Revisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Revisao.Repositories
{
    public interface IPedidoRepository
    {
        void Cadastrar(Pedido pedido);
        List<Pedido> Listar();
        void Atualizar(Pedido pedido);
        void Remover(int codigo);
    }
}
