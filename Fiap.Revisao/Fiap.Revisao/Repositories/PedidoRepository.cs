using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.Models;
using Fiap.Revisao.Persistence;
using System.Data.Entity;

namespace Fiap.Revisao.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {

        private LojaContext _context = new LojaContext();


        public PedidoRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
        }

        public void Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
        }

        public List<Pedido> Listar()
        {
            return _context.Pedidos.Include("Cliente").ToList();
        }

        public void Remover(int codigo)
        {
            Pedido pedido = _context.Pedidos.Find(codigo);
            _context.Pedidos.Remove(pedido);
        }
    }
}